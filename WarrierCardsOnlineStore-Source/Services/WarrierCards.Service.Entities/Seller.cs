using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("sellers")]
    public partial class Seller
    {

        [Column("user_id")]
        [Required]
        [Key]
        public int UserId { get; set; }

        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; }

        [Column("district")]
        [StringLength(20)]
        public string District { get; set; }

        [Column("state")]
        [StringLength(20)]
        public string State { get; set; }

        [Column("country")]
        [StringLength(20)]
        public string Country { get; set; }

        [Column("pincode")]
        [StringLength(10)]
        public string Pincode { get; set; }

        [Column("phone2")]
        [StringLength(12)]
        public string Phone2 { get; set; }

        [Column("website")]
        [StringLength(10)]
        public string Website { get; set; }

        [Column("fee_percentage")]
        [Required]
        public int FeePercentage { get; set; }

        [Column("account_number")]
        [StringLength(10)]
        public string AccountNumber { get; set; }

        [Column("account_type")]
        [StringLength(10)]
        public string AccountType { get; set; }

        [Column("transaction_profile_id")]
        [StringLength(50)]
        public string TransactionProfileId { get; set; }

        [ForeignKey("User")]

        public virtual User User { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

        public virtual ICollection<SellerPayment> SellerPayments { get; set; }

    }
}
