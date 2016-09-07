using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WarrierCards.Website.CatalogueService;
using WarrierCards.Website.Common;
using WarrierCards.Website.Models;
using WarrierCards.Website.SecurityService;

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
            List<SelectedCardInfo> cardInfos = new List<SelectedCardInfo>();
            if (Request.Cookies["wc_shortlist"] != null)
            {
                var cart = Request.Cookies["wc_shortlist"].Value;
                cardInfos = this.GetSelectedCardInfo(cart);
            }

            return View("ViewShortlist", cardInfos);
        }

        [Authorize]
        [ActionName("shipping-address")]
        public ActionResult ShippingAddress(string id)
        {
            List<ShippingAddress> addresses = null;
            using (var catalogueService = new CatalogueServiceClient())
            {
                addresses = catalogueService.GetShippingAddressesByUserId(CustomWebSecurity.UserId);
            }

            // TODO: code for demo, just remove this block
            {
                addresses = new List<ShippingAddress>();
                addresses.Add(new ShippingAddress { RecipientName = "Prince Joseph", AddressId = 1, FullAddress = "test address", Mobile = "91-9847399001", Landmark = "Landmark1", Pincode = "00065" });
                addresses.Add(new ShippingAddress { RecipientName = "Recipient One", AddressId = 2, FullAddress = "test address 2", Mobile = "91-9847399001", Landmark = "Landmark2", Pincode = "00065" });
            }

            ViewBag.SavedShippingAddresses = addresses;

            // If Id is present, edit the address corresponding to addressId
            ShippingAddress model = null;
            int addressId = Convert.ToInt32(id);
            if (addressId > 0 && addresses != null && addresses.Find(x => x.AddressId == addressId) != null)
            {
                model = addresses.Find(x => x.AddressId == addressId);
            }

            return View("ShippingAddress", model);
        }

        [Authorize]
        [HttpPost]
        [ActionName("shipping-address")]
        [ValidateAntiForgeryToken]
        public ActionResult ShippingAddress(ShippingAddress model)
        {
            try
            {
                int shpAddressId;
                if (Request.Form["UseExistingAddress"] != null)
                {
                    shpAddressId = Convert.ToInt32(Request.Form["rdoShipping"]);
                    if (shpAddressId < 0) { throw new Exception("No shipping address selected."); }
                }
                else
                {
                    using (var catalogueService = new CatalogueServiceClient())
                    {
                        shpAddressId = catalogueService.SaveShippingAddress(CustomWebSecurity.UserId, model);
                    }
                }
                System.Web.HttpContext.Current.Session["ShippingAddressId"] = shpAddressId;

                return RedirectToAction("review-order", "my");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error: " + ex.Message);

                return View("ShippingAddress", model);
            }
        }

        [Authorize]
        [ActionName("review-order")]
        public ActionResult ReviewOrder()
        {
            try
            {

                int shpAddressId = Convert.ToInt32(System.Web.HttpContext.Current.Session["ShippingAddressId"]);
                if (Request.Cookies["wc_cart"] == null || shpAddressId < 1)
                {
                    throw new Exception("Missing required information. Verify cart and shipping information.");
                }

                ReviewOrderModel model = new ReviewOrderModel();
                using (var catalogueService = new CatalogueServiceClient())
                {
                    model.ShippingAddress = catalogueService.GetShippingAddressById(CustomWebSecurity.UserId, shpAddressId);
                }
                model.SelectedCards = this.GetSelectedCardInfo(Request.Cookies["wc_cart"].Value);

                return View("ReviewOrder", model);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "my", "review-order"));
            }
        }

        [ActionName("order-summary")]
        public PartialViewResult OrderSummary()
        {
            try
            {
                if (Request.QueryString["Coupon"] != null)
                {
                    System.Web.HttpContext.Current.Session["Coupon"] = Request.QueryString["Coupon"];
                }

                int shpAddressId = Convert.ToInt32(System.Web.HttpContext.Current.Session["ShippingAddressId"]);
                List<SelectedCard> selectedCards = ParseSelectedCardsFromCookie(Request.Cookies["wc_cart"].Value);
                string couponCode = Convert.ToString(System.Web.HttpContext.Current.Session["Coupon"]);

                OrderSummaryParams args = new OrderSummaryParams();
                args.ShippingAddressId = shpAddressId;
                args.SelectedCards = selectedCards;
                args.couponCode = couponCode;
                OrderSummary model = null;
                using (var catalogueService = new CatalogueServiceClient())
                {
                    model = catalogueService.GetOrderSummary(CustomWebSecurity.UserId, args);
                }

                return PartialView("_OrderSummaryPartial", model);

            }
            catch (Exception ex)
            {
                return PartialView("Error", new HandleErrorInfo(ex, "my", "ordersummary"));
            }
        }

        private List<SelectedCardInfo> GetSelectedCardInfo(string cookieValue)
        {
            List<SelectedCardInfo> cardInfos = null;
            List<SelectedCard> list = ParseSelectedCardsFromCookie(cookieValue);
            if (list != null && list.Count > 0)
            {
                using (var catalogueService = new CatalogueServiceClient())
                {
                    cardInfos = catalogueService.GetCardsInfoByIds(list);
                }
            }

            return cardInfos;
        }

        private static List<SelectedCard> ParseSelectedCardsFromCookie(string cookieValue)
        {
            List<SelectedCard> list = null;
            if (!string.IsNullOrEmpty(cookieValue))
            {
                cookieValue = HttpUtility.UrlDecode(cookieValue);
                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                list = JsonConvert.DeserializeObject<List<SelectedCard>>(cookieValue);
            }

            return list;
        }

    }
}
// TODO: PRINCE: To Test, A logged in user adds some items in shortlist, 
//another user (logged in or not), using the same PC shouldn't be seeing them in their shortlist: test cookie privacy

// TODO: PRINCE - Conflicts when cookie and db has different shortlists/carts, which one to use. save timestamps too?