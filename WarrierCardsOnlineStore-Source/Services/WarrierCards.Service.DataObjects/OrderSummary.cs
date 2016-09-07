using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects
{
    [DataContract]
    public class OrderSummary
    {
        private decimal total;

        [DataMember]
        public decimal EstimatedTotal { get; set; }

        [DataMember]
        public double ShippingWeight { get; set; }

        [DataMember]
        public decimal ShippingCost { get; set; }

        [DataMember]
        public string CouponCode { get; set; }

        [DataMember]
        public decimal CouponDiscount { get; set; }

        [DataMember]
        public string CouponError { get; set; }


        [DataMember]
        public decimal Total
        {
            get { return EstimatedTotal + ShippingCost - CouponDiscount; }
            protected set { total = value; }
        }

        [DataMember]
        public decimal TotalSavings { get; set; }
    }
}
