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

        [ActionName("card-details")]
        public ActionResult CardDetails(int cardId)
        {
            CardDetailsModel model = new CardDetailsModel();
            ICatalogueService catalogueService = new CatalogueServiceClient();
            model.CardDetails = catalogueService.GetCardDetailsById(cardId);

            return View("CardDetails", model);
        }

        [ActionName("quick-view")]
        public PartialViewResult QuickView(int cardId)
        {
            ICatalogueService catalogueService = new CatalogueServiceClient();
            var model = catalogueService.GetCardQuickViewData(cardId);

            return PartialView("QuickView", model);
        }

        [HttpGet]
        [ActionName("send-enquiry")]
        public PartialViewResult ShowEnquiryForm(int cardId)
        {
            var model = new UserInfoModel();
            model.UserId = Convert.ToInt32(Request.RequestContext.HttpContext.Session["UserID"]);
            ViewBag.CardId = cardId;

            return PartialView("Enquiry", model);
        }

        [HttpPost]
        [ActionName("send-enquiry")]
        public bool SendEnquiry(UserInfoModel userInfo)
        {
            EnquiryData enquiry = new EnquiryData();
            var userId = Convert.ToInt32(Request.RequestContext.HttpContext.Session["UserID"]);
            if (userId == 0)
            {
                enquiry.UserInfo = new UserData();
                enquiry.UserInfo.FirstName = userInfo.FirstName;
                enquiry.UserInfo.LastName = userInfo.LastName;
                enquiry.UserInfo.Email = userInfo.Email;
                enquiry.UserInfo.CountryCode = userInfo.CountryCode;
                enquiry.UserInfo.Phone = userInfo.Phone;
            }
            enquiry.CardId = Convert.ToInt32(Request["CardId"]);
            enquiry.Query = Request["Enquiry"];

            ICatalogueService catalogueService = new CatalogueServiceClient();
            var result = catalogueService.SendEnquiry(enquiry);

            return result;
        }

        
    }
}
