using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects
{
    [DataContract]
    public class CardDetails : CardItem
    {
        [DataMember]
        public List<string> CardImages { get; set; }
    }
}
