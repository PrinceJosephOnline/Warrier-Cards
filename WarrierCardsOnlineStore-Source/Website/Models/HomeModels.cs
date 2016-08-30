using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarrierCards.Website.CatalogueService;

namespace WarrierCards.Website.Models
{
    public class HomeModel
    {
        //public string BestSellers { get; set; }

        public List<CardBasicInfo> BestSellers { get; set; }

        public List<CardBasicInfo> PremiumCards { get; set; }
    }
}