using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WarrierCards.Service.DataObjects
{
    [DataContract]
    public class EnquiryData
    {
        [DataMember]
        public int? UserId { get; set; }

        [DataMember]
        public int CardId { get; set; }

        [DataMember]
        public string Query { get; set; }

        [DataMember]
        public UserData UserInfo { get; set; }

        public bool Validate()
        {
            if (UserId < 1)
            {
                if (this.UserInfo == null)
                {
                    throw new Exception("User information is missing");
                }
                else
                {
                    this.UserInfo.Validate();
                }
            }

            if (CardId < 1)
            {
                throw new Exception("Card ID is missing");
            }

            if (string.IsNullOrEmpty(Query))
            {
                throw new Exception("Enquiry cannot be blank");
            }

            return true;
        }
    }
}
