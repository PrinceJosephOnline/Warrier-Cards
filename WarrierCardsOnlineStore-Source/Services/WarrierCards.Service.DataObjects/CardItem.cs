using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects
{
    [DataContract]
    public class CardItem
    {
        [DataMember]
        public int CardId { get; set; }

        [DataMember]
        public string CardModelNumber { get; set; }

        [DataMember]
        public string CardName { get; set; }

        [DataMember]
        public string CardMainImagePath { get; set; }

        [DataMember]
        public decimal CardOrginalPrice { get; set; }

        [DataMember]
        public decimal CardSellingPrice { get; set; }

        [DataMember]
        public bool IsPortrait { get; set; }
    }
}
