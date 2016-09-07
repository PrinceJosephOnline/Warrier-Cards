using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using WarrierCards.Website.Common;
using WarrierCards.Website.SecurityService;

namespace WarrierCards.Website.Controllers
{
    public class AccountController : Controller
    {
        [ActionName("login")]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            // TODO; Remember me autologin -- cookie: WarrierCardsLogin

            return View("Login");
        }

        [HttpPost]
        [ActionName("login")]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserInfo userInfo)
        {
            try
            {
                bool? rememberMe = null;
                if (Request.Form["RememberMe"] == "on")
                {
                    rememberMe = true;
                }
                else if (Request.Form["RememberMe"] == "off")
                {
                    rememberMe = false;
                }
                if (!CustomWebSecurity.Login(userInfo.Email, userInfo.Password, rememberMe))
                {
                    throw new Exception("Unable to login");
                }

                if (!string.IsNullOrEmpty(Request["ReturnUrl"]))
                {
                    return Redirect(Request["ReturnUrl"]);
                }
                else
                {
                    return RedirectToAction("view-cart", "my");
                }

                // TODO: use a cookie to manage return URL
                // (Request.UrlReferrer != null && Request.UrlReferrer.ToString()
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error: " + ex.Message);
                return View("Login");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserInfo userInfo)
        {
            try
            {
                CustomWebSecurity.Register(userInfo);
                return RedirectToAction("view-shortlist", "my"); // TODO: use a cookie to manage return URL
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error: " + ex.Message);
                return View("Login");
            }
        }

        public ActionResult Reset(string id)
        {
            try
            {
                ViewBag.IsResetRequest = string.IsNullOrEmpty(id);
                ViewBag.Title = ViewBag.IsResetRequest ? "Reset Password" : "Change Password";
                // if ID is present, validate ID  & show change password
                if (ViewBag.IsResetRequest)
                {
                    using (var securityService = new SecurityServiceClient())
                    {
                        securityService.ValidateChangePasswordToken(id);
                    }

                    // TODO: if validation fails, catch a specific exception &
                    // show the password reset form,set  ViewBag.IsResetRequest = true, title
                }
            }
            catch (Exception ex)
            {
                ViewBag.IsResetRequest = true;
                ModelState.AddModelError("", "Error: " + ex.Message);
                return View("Login");
            }

            return View("ResetPassword");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reset(FormCollection formData)
        {
            try
            {
                using (var securityService = new SecurityServiceClient())
                {
                    if (formData["btnAction"] == "Reset")
                    {
                        ViewBag.IsResetRequest = false;
                        string email = formData["Email"];
                        securityService.SendPasswordResetEmail(email);
                        // TODO: display info message & any redirections
                    }
                    else
                    {
                        ViewBag.IsResetRequest = true;
                        string token = formData["Token"];
                        string password = formData["Password"];
                        securityService.ChangePassword(token, password);
                        // TODO: display info message & any redirections
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.IsResetRequest = true;
                ModelState.AddModelError("", "Error: " + ex.Message);
                return View("Login");
            }

            return View("ResetPassword");
        }


    }
}