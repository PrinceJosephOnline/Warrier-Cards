using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects
{
    [DataContract]
    public class OrderSummaryParams
    {
        [DataMember]
        public int ShippingAddressId { get; set; }

        [DataMember]
        public List<SelectedCard> SelectedCards { get; set; }

        [DataMember]
        public string couponCode { get; set; }
    }
}
