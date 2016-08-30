using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarrierCards.Website.CatalogueService;
using WarrierCards.Website.Common;

namespace WarrierCards.Website.Models
{
    public class CatalogueModel
    {
        public string PageTitle {
            get 
            { 
                string title = string.IsNullOrEmpty(this.Criteria.Keywords) ? "All Cards" : this.Criteria.Keywords;
                return title.Replace('-', ' ').ToTitleCase();
            }
        }

        public SearchCriteria Criteria { get; set; }

        public List<CardBasicInfo> CardsCollection { get; set; }
    }
}