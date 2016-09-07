using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WarrierCards.Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "CardActivity",
              url: "catalogue/{action}/{cardId}",
              defaults: new { controller = "Catalogue", action = "Index" }
          );

            routes.MapRoute(
               name: "Catalogue",
               url: "catalogue/{keywords}",
               defaults: new { controller = "Catalogue", action = "Index" }
           );

            routes.MapRoute(
               name: "OrderActivity",
               url: "my/{action}/{id}",
               defaults: new { controller = "OrderProcess", action = "view-cart", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}