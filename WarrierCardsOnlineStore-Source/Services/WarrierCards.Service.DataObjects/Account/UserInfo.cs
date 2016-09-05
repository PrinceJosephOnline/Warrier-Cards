using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects.Account
{
    [DataContract]
    public class UserInfo : LoginInfo
    {
        public UserInfo(string email, string password)
            : base(email, password)
        { 
        
        }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public string Phone { get; set; }

        public new bool Validate()
        {
            return false;
            // TODO: PRINCE - implement object validation
        }
    }
}
