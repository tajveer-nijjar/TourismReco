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
            var currentUserName = User.Identity.GetUserName();

            foreach (var clan in checkedClans)
            {
                var userClanRegistration = new UserClanRegisteration()
                {
                    ClanId = clan.ClanId,
                    UserId = currentUserId
                };


                _context.UserClanRegisterations.Add(userClanRegistration);
            }

            _context.SaveChanges();

            return View("SelectClanPriority", checkedClans);
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
            
            return View("SelectSubClans");
        }
    }
}