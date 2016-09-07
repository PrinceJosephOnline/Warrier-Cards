using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WarrierCards.Website.CatalogueService;

namespace WarrierCards.Website.Models
{
    public class ReviewOrderModel
    {
        public ShippingAddress ShippingAddress { get; set; }

        public List<SelectedCardInfo> SelectedCards { get; set;  }

       // public OrderSummary OrderSummary { get; set; }
    }
}