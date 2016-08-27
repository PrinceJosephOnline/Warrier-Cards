using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarrierCards.Website.CatalogueService;
using WarrierCards.Website.Models;

namespace WarrierCards.Website.Controllers
{
    public class CatalogueController : Controller
    {
        //[HttpGet]
        public ActionResult Index()
        {
            SearchCriteria criteria = new SearchCriteria();
            criteria.Keywords = Convert.ToString(RouteData.Values["keywords"]);
            ViewBag.Title = string.IsNullOrEmpty(criteria.Keywords) ? " - View all our Cards" : "- " + criteria.Keywords;
            
            CatalogueModel model = new CatalogueModel();
            ICatalogueService catalogueService = new CatalogueServiceClient();
            model.CardsCollection = catalogueService.GetCardsList(criteria);
            model.Criteria = criteria;

            return View("CatalogueView", model);
        }

        public ActionResult CardDetails(int cardId)
        {
            CardDetailsModel model = new CardDetailsModel();
            ICatalogueService catalogueService = new CatalogueServiceClient();
            model.CardDetails = catalogueService.GetCardDetailsById(cardId);

            return View(model);
        }
    }
}
