using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects
{
    [DataContract]
    public class ShippingAddress
    {
        [DataMember]
        public int AddressId { get; set; }

        //[DataMember]
        //public int UserId { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string FullAddress { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string Landmark { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string Pincode { get; set; }

        [DataMember]
        public string Mobile { get; set; }
    }
}
