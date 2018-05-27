using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TourismReco2.Models;
using TourismReco2.Models.ViewModels;

namespace TourismReco2.Controllers
{
    public class RecommendationsController: Controller
    {
        private readonly ApplicationDbContext _context;

        public RecommendationsController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize]
        public ActionResult RecommendationsForm()
        {
            var clans = _context.Clans.ToList();
            var userId = User.Identity.GetUserId();
            
            var viewModel = new RecommendationsFormViewModel
            {
//                UserId = userId,
                Clans = clans
            };
            
            return View(viewModel);
        }

        public ActionResult Recommendations(RecommendationsFormViewModel viewModel)
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
            var userClansIdDatabase = _context.UserClanRegisterations.Where(u => u.UserId == userId).ToList();

            //Storing selected clan preference in UserClanRegistration table.
            foreach (var userClan in userClansIdDatabase)
            {
                //Finding if UserClan in database is present in current selection
                var selectedClan = clans.SingleOrDefault(c => c.ClanId == userClan.ClanId);
                if (selectedClan != null)
                {
                    userClan.ClanPreference = selectedClan.ClanPreference;
                }
            }

            _context.SaveChanges();
            
            return View("SelectSubClans");
        }
    }
}