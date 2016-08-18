using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarrierCards.Service.DataObjects.Common;

namespace WarrierCards.Service.DataObjects
{
    public class SearchCriteria
    {
        public SearchCriteria()
        {
            this.LastItemIndex = 0;
            this.ItemsReturnedPerRequest = 20;
        }

        public decimal LowPrice { get; set; }

        public decimal HighPrice { get; set; }

        public CardTypes CardType { get; set; } 

        public List<string> CardColors { get; set; }

        // For pagination, 0 => first page
        public int LastItemIndex { get; set; }

        // For pagination, item per page; 0 => all
        public int ItemsReturnedPerRequest { get; set; }    
    }
}
