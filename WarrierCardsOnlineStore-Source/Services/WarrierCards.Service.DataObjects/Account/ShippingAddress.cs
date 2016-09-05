using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects.Account
{
    [DataContract]
    public class ShippingAddress
    {
        [DataMember]
        public int AddressId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string FullAddress { get; set; }

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
