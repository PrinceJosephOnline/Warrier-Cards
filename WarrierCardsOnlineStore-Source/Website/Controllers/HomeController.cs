using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarrierCards.Website.ListingService;
using WarrierCards.Website.Models;

namespace WarrierCards.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome";

            SearchCriteria criteria = new SearchCriteria();
            criteria.LowPrice = 21;

            IListingService listingService = new ListingServiceClient();
            HomeModel homeModel = new HomeModel();
            homeModel.BestSellers = listingService.GetCardsList(criteria);

            criteria.LowPrice = 21;
            criteria.HighPrice = 150;
            homeModel.PremiumCards = listingService.GetCardsList(criteria);

            return View(homeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
