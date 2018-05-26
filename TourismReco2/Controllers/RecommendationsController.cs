using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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


        public ActionResult RecommendationsForm()
        {
            var clans = _context.Clans.ToList();

            var viewModel = new RecommendationsFormViewModel
            {
                Clans = clans
            };
            
            return View(viewModel);
        }

        public ActionResult Recommendations()
        {

            return View();
        }
    }
}