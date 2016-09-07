using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarrierCards.Website.CatalogueService;
using WarrierCards.Website.Common;
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
            using (var catalogueService = new CatalogueServiceClient())
            {
                model.CardsCollection = catalogueService.GetCardsList(criteria);
            }
            model.Criteria = criteria;

            return View("CatalogueView", model);
        }

        [ActionName("card-details")]
        public ActionResult CardDetails(int cardId)
        {
            CardDetailsModel model = new CardDetailsModel();
            using (var catalogueService = new CatalogueServiceClient())
            {
                model.CardDetails = catalogueService.GetCardDetailsById(cardId);
            }
            return View("CardDetails", model);
        }

        [ActionName("quick-view")]
        public PartialViewResult QuickView(int cardId)
        {
            CardQuickViewData model = null;
            using (var catalogueService = new CatalogueServiceClient())
            {
                model = catalogueService.GetCardQuickViewData(cardId);
            }

            return PartialView("QuickView", model);
        }

        [HttpGet]
        [ActionName("send-enquiry")]
        public PartialViewResult ShowEnquiryForm(int cardId)
        {
            var model = new EnquiryData();
            model.UserId = CustomWebSecurity.UserId;
            model.CardId = cardId;

            return PartialView("_Enquiry", model);
        }

        [HttpPost]
        [ActionName("send-enquiry")]
        public bool SendEnquiry(EnquiryData enquiryData)
        {
            enquiryData.UserId = CustomWebSecurity.UserId;
            enquiryData.Fullname = CustomWebSecurity.Username;
            bool sent = false;
            using (var catalogueService = new CatalogueServiceClient())
            {
                sent = catalogueService.SendEnquiry(enquiryData);
            }

            return sent;
        }


    }
}
