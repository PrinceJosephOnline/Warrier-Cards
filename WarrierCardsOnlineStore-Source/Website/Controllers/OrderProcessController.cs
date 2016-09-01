using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WarrierCards.Website.CatalogueService;

namespace WarrierCards.Website.Controllers
{
    public class OrderProcessController : Controller
    {
        [ActionName("view-cart")]
        public ActionResult ViewCart()
        {
            List<SelectedCardInfo> cardInfos = null;
            if (Request.Cookies["wc_cart"] != null)
            {
                var cart = Request.Cookies["wc_cart"].Value;
                cardInfos = this.GetSelectedCardInfo(cart);
            }

            ViewBag.EstimatedTotal = 0.00; // TODO calcualate this
            ViewBag.ShippingCost = "Extra";
            ViewBag.Total = ViewBag.EstimatedTotal + " + Shipping";
            return View("ViewCart", cardInfos);
        }

        [ActionName("view-shortlist")]
        public ActionResult ViewShortlist()
        {
            List<SelectedCardInfo> cardInfos = null;
            if (Request.Cookies["wc_shortlist"] != null)
            {
                var cart = Request.Cookies["wc_shortlist"].Value;
                cardInfos = this.GetSelectedCardInfo(cart);
            }

            return View("ViewShortlist", cardInfos);
        }


        private List<SelectedCardInfo> GetSelectedCardInfo(string cookieValue)
        {
            List<SelectedCardInfo> cardInfos = null;
            if (!string.IsNullOrEmpty(cookieValue))
            {
                cookieValue = HttpUtility.UrlDecode(cookieValue);
                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                List<SelectedCard> list = JsonConvert.DeserializeObject<List<SelectedCard>>(cookieValue);

                ICatalogueService catalogueService = new CatalogueServiceClient();
                cardInfos = catalogueService.GetCardsInfoByIds(list);
            }

            return cardInfos;
        }

    }
}
// TODO: PRINCE: To Test, A logged in user adds some items in shortlist, 
//another user (logged in or not) shouldn't get them in shirtlist

// TODO: PRINCE - Conflicts when cookie and db has different short;ists/carts, which one to use. save timestamps too?