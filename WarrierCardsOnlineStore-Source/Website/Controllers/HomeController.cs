using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarrierCards.Website.CatalogueService;
using WarrierCards.Website.Models;

namespace WarrierCards.Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome";

            SearchCriteria criteria = new SearchCriteria();
            criteria.LowPrice = 21;

            ICatalogueService catalogueService = new CatalogueServiceClient();
            HomeModel homeModel = new HomeModel();
            homeModel.BestSellers = catalogueService.GetCardsList(criteria);

            criteria.LowPrice = 21;
            criteria.HighPrice = 150;
            homeModel.PremiumCards = catalogueService.GetCardsList(criteria);

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
