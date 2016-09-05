using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects.Account
{
    [DataContract]
    public class LoginInfo
    {
        public LoginInfo(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        public void Validate()
        {
            // TODO: PRINCE - implement validation
        }
    }
}
