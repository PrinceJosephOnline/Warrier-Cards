using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarrierCards.Website.CatalogueService;

namespace WarrierCards.Website.Models
{
    public class CardDetailsModel
    {
        public SearchCriteria Criteria { get; set; }

        public CardDetails CardDetails { get; set; }
    }
}