using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("shipping_addresses")]
    public partial class ShippingAddress
    {

        [Column("address_id")]
        [Required]
        [Key]
        public int AddressId { get; set; }

        [Column("Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("full_address")]
        [StringLength(-1)]
        public string FullAddress { get; set; }

        [Column("pincode")]
        [StringLength(50)]
        public string Pincode { get; set; }

        [Column("landmark")]
        [StringLength(200)]
        public string Landmark { get; set; }

        [Column("country")]
        [StringLength(50)]
        public string Country { get; set; }

        [Column("mobile")]
        public Nullable<double> Mobile { get; set; }

        [Column("user_id")]
        [Required]
        public int UserId { get; set; }


        public virtual ICollection<Order> Orders { get; set; }

    }
}
