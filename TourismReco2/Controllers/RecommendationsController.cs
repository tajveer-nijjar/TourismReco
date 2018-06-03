using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TourismReco2.HelperClasses;
using TourismReco2.Models;
using TourismReco2.Models.ViewModels;

namespace TourismReco2.Controllers
{
    public class RecommendationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private List<CalculatedRecommendation> _calculatedRecommendations;
        private List<SelectedRecommendation> _selectedRecommendations;
        private CalculatedRecommendation _calculatedRecommendation;

        public RecommendationsController()
        {
            _context = new ApplicationDbContext();
            _calculatedRecommendations = new List<CalculatedRecommendation>();
            _selectedRecommendations = new List<SelectedRecommendation>();
            _calculatedRecommendation = new CalculatedRecommendation();
        }

//        protected override void Dispose(bool disposing)
//        {
//            _context.Dispose();
//        }

        [Authorize]
        public ActionResult RecommendationsForm()
        {
            var clans = _context.Clans.ToList();
            var userId = User.Identity.GetUserId();

            var viewModel = new RecommendationsFormViewModel
            {
                UserId = userId,
                Clans = clans
            };

            return View(viewModel);
        }

        public ActionResult SaveSelectedClans(RecommendationsFormViewModel viewModel)
        {
            var checkedClans = viewModel.Clans.Where(c => c.IsSelected == true).ToList();

            var currentUserId = User.Identity.GetUserId();

            //Fetching already selected clans against this user:
            var userClans = _context.UserClanRegisterations.Where(u => u.UserId == currentUserId).ToList();

            foreach (var clan in checkedClans)
            {
                var userClanRegistration = new UserClanRegisteration()
                {
                    ClanId = clan.ClanId,
                    UserId = currentUserId
                };

                //Checking if user already registered to the clan.
                var x = userClans.FirstOrDefault(uc => uc.UserId == currentUserId && uc.ClanId == clan.ClanId);
                if (x == null)
                {
                    _context.UserClanRegisterations.Add(userClanRegistration);
                    userClans.Add(userClanRegistration);
                }

            }

            _context.SaveChanges();

            //Fetching only clans that are registered to a user
            var clans = new List<Clan>();
            var allClans = _context.Clans.ToList();
            foreach (var clanRegisteration in userClans)
            {
                var registeredClan = allClans.SingleOrDefault(ac => ac.ClanId == clanRegisteration.ClanId);
                registeredClan.UserId = currentUserId;
                clans.Add(registeredClan);
            }



            return View("SelectClanPriority", clans);
        }

        public ActionResult SaveClanPriority(List<Clan> clans)
        {
            foreach (var clan in clans)
            {
                if (clan.ClanPreference == 1)
                {
                    clan.ClanPreference = .3;
                }
                else if (clan.ClanPreference == 2)
                {
                    clan.ClanPreference = .6;
                }
                else if (clan.ClanPreference == 3)
                {
                    clan.ClanPreference = 1;
                }
            }

            //Fetching all clans stored against this user.
            var userId = User.Identity.GetUserId();
            var userClansInDatabase = _context.UserClanRegisterations.Where(u => u.UserId == userId).ToList();

            //Storing selected clan preference in UserClanRegistration table.
            foreach (var clanRegisteration in userClansInDatabase)
            {
                //Finding if UserClan in database is present in current selection
                var selectedClan = clans.SingleOrDefault(c =>
                    c.ClanId == clanRegisteration.ClanId && c.UserId == clanRegisteration.UserId);
                if (selectedClan != null)
                {
                    clanRegisteration.ClanPreference = selectedClan.ClanPreference;
                }
            }

            _context.SaveChanges();

            //Populate all Clans with respective SubClans to be sent to next page.

            //Get all clans including subclans
            var allSubClans = _context.SubClans.ToList();
            var allClans = _context.Clans.ToList();

            var selectedClans = new List<Clan>();

            foreach (var userClan in userClansInDatabase)
            {
                var x = allClans.SingleOrDefault(ac => ac.ClanId == userClan.ClanId);
                selectedClans.Add(x);
            }

            return View("SelectSubClans", selectedClans);
        }

        public ActionResult SaveSubClanPriority(List<Clan> clans)
        {
            var userClanRegistrations = _context.UserClanRegisterations.ToList();
            var subClansInDb = _context.SubClans.ToList();
            var clansInDb = _context.Clans.ToList();
            var registeredClans = new List<Clan>();
            var allSubClanPriorityRegistrations = _context.SubClanPriorityRegistrations.ToList();

            //Adding ClanPreference values that are stored in the database to the "clans" list.
            foreach (var clanRegisteration in userClanRegistrations)
            {
                var clan = clansInDb.FirstOrDefault(c => c.ClanId == clanRegisteration.ClanId);
                if (clanRegisteration.UserId == User.Identity.GetUserId())
                {
                    clan.ClanPreference = clanRegisteration.ClanPreference;
                    registeredClans.Add(clan);
                }
            }

            var subClans = clans.SelectMany(c => c.SubClans).ToList();

            //Adding SubClanPriorities
            foreach (var clan in registeredClans)
            {
                foreach (var subClan in clan.SubClans)
                {
                    var foundSubClan = subClans.SingleOrDefault(s => s.SubClanId == subClan.SubClanId);

                    subClan.SubClanPriority = foundSubClan.SubClanPriority;
                }
            }


            foreach (var clan in registeredClans)
            {
                foreach (var subClan in clan.SubClans)
                {
                    var subClanPriorityRegistration = new SubClanPriorityRegistration()
                    {
                        SubClanId = subClan.SubClanId,
                        UserId = User.Identity.GetUserId(),
                        PriorityLevel = clan.ClanPreference * subClan.SubClanPriority
                    };

                    var isPresent = allSubClanPriorityRegistrations.Any(r =>
                        r.UserId == User.Identity.GetUserId() && r.SubClanId == subClan.SubClanId);
                    if (!isPresent)
                    {
                        _context.SubClanPriorityRegistrations.Add(subClanPriorityRegistration);
                    }
                }
            }

            _context.SaveChanges();

            CalculateRecommendations();

            var viewModel = CreateViewModelToShow();

            return View("ShowRecommendations", viewModel);
        }

        public async Task<ActionResult> SaveAndShowSelectedRecommendations(ShowRecommendationsViewModel viewModel)
        {
            var allFinalRecommendations = _context.SelectedRecommendations.ToList();
            
            var recommendations = new List<CalculatedRecommendation>();
            foreach (var recommendation in viewModel.CalculatedRecommendations)
            {
                if (recommendation.ChosenByUser != null)
                {
                    if (recommendation.ChosenByUser == true)
                    {
                        recommendations.Add(recommendation);

                        var selectedRecommendation = new SelectedRecommendation()
                        {
                            ItemId = recommendation.ItemId,
                            CalcultedWeight = recommendation.CalcultedWeight,
                            ChosenByUser = recommendation.ChosenByUser,
                            Item = recommendation.Item,
                            SubClandId = recommendation.SubClandId,
                            UserId = recommendation.UserId
                        };

                        var ifPresent = allFinalRecommendations
                            .Any(r => r.ItemId == recommendation.ItemId && r.UserId == User.Identity.GetUserId());

                        if (!ifPresent)
                        {
                            _context.SelectedRecommendations.Add(selectedRecommendation);
                            _selectedRecommendations.Add(selectedRecommendation);
                        }
                    }
                }
            }

            await FillDataWithItems();

            _context.SaveChanges();

            //Retreiving all the recommendations for the user to be displayed.
            var userId = User.Identity.GetUserId();
            var finalRecommendations = _context.SelectedRecommendations.Where(r => r.UserId == userId).ToList();
            
            return View(finalRecommendations);
        }



        
        //************************************PRIVATE METHODS************************************//

        
        
        private void CalculateRecommendations()
        {
            var subClanRegistrations = _context.SubClanPriorityRegistrations.ToList();

            var subClanRegistrationsForCurrentUSer =
                subClanRegistrations.Where(r => r.UserId == User.Identity.GetUserId()).ToList();

            //            var subClans = subClanRegistrationsForCurrentUSer.Where(r => r.SubClanId);

            var allItems = _context.Items.ToList();

            foreach (var registration in subClanRegistrationsForCurrentUSer)
            {
                var subClanId = registration.SubClanId;

                var subClanItems = allItems.Where(a => a.SubClanId == subClanId).ToList();

                foreach (var subClanItem in subClanItems)
                {
                    _calculatedRecommendation = new CalculatedRecommendation()
                    {
                        UserId = User.Identity.GetUserId(),
                        CalcultedWeight = (subClanItem.ItemRating * registration.PriorityLevel).Value,
                        ItemId = subClanItem.ItemId,
                        Item = subClanItem,
                        SubClandId = subClanId
                    };

                    //                    _context.CalculatedRecommendations.Add(calculatedReco);
                    _calculatedRecommendations.Add(_calculatedRecommendation);
                }
            }

            //            _context.SaveChanges();
        }


        private ShowRecommendationsViewModel CreateViewModelToShow()
        {
            //            var allCalculatedReco = _context.CalculatedRecommendations.ToList();

            foreach (var calculatedRecommendation in _calculatedRecommendations)
            {
                calculatedRecommendation.ChosenByUser = false;
            }

            var recoForCurrentUser = _calculatedRecommendations.Where(r => r.UserId == User.Identity.GetUserId()).OrderByDescending(r => r.CalcultedWeight).ToList();

            var viewModel = new ShowRecommendationsViewModel()
            {
                CalculatedRecommendations = recoForCurrentUser
            };

            return viewModel;
        }

        private async Task FillDataWithItems()
        {
            var allItems = _context.Items.ToList();

            foreach (var recommendation in _selectedRecommendations)
            {
                var item = allItems.FirstOrDefault(i => i.ItemId == recommendation.ItemId);

                recommendation.Item = item;

                var geoPoint = await GenerateGeoPoints(recommendation.Item.ItemAddress);
                recommendation.Item.GeoPoint = geoPoint;
            }
        }

        private async Task<GeoPoint> GenerateGeoPoints(string address)
        {
            var result = await GoogleAddressSearch.SearchAsync(address);

            GeoPoint geoPoint = (result == null)
                ? new GeoPoint() { Lat = -41.318847, Lng = 174.805794 }   //Tranzit office's address
                : new GeoPoint() { Lat = result.Latitude, Lng = result.Longitude };

            return geoPoint;
        }

    }
}