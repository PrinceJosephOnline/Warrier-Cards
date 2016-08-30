using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WarrierCards.Website.Models
{
    public class UserInfoModel
    {
        public UserInfoModel()
        {
            this.CountryCode = "91";
        }

        public int UserId { get; set; }

        [Required(ErrorMessage = "Firstname is mandatory")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Invalid Firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is mandatory")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Invalid Lastname")]
        public string LastName { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 8, ErrorMessage = "E-mail is not valid")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "Country code is not valid")]
        public string CountryCode { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 10)]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Phone is not valid")]
        public string Phone { get; set; }
    }
}