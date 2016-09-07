using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects.Account;

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
        public string Fullname { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Query { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Phone))
            {
                throw new Exception("Email and Phone number are mandatory");
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

    //[DataContract]
    //public class UserInfoTemp // TODO:PRINCE - solve this, temp solution for Ambigious reference
    //{
    //    [DataMember]
    //    public string Email { get; set; }

    //    [DataMember]
    //    public int UserId { get; set; }

    //    [DataMember]
    //    public string FirstName { get; set; }

    //    [DataMember]
    //    public string LastName { get; set; }

    //    [DataMember]
    //    public string CountryCode { get; set; }

    //    [DataMember]
    //    public string Phone { get; set; }

    //    public bool Validate()
    //    {
    //        return true;
    //    }
    //}
}
