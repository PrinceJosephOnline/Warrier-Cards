using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("users")]
    public partial class User
    {

        [Column("user_id")]
        [Required]
        [Key]
        public int UserId { get; set; }

        [Column("first_name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Column("last_name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Column("password")]
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Column("email_id")]
        [Required]
        [StringLength(200)]
        public string EmailId { get; set; }

        [Column("phone")]
        [Required]
        public double Phone { get; set; }

        [Column("registered_date")]
        [Required]
        public DateTime RegisteredDate { get; set; }

        [Column("last_login_date")]
        public Nullable<DateTime> LastLoginDate { get; set; }

        [Column("is_active")]
        [Required]
        public bool IsActive { get; set; }


        public virtual ICollection<Seller> Sellers { get; set; }

        public virtual ICollection<Testimonial> Testimonials { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public virtual ICollection<OrderManagement> OrderManagements { get; set; }

    }
}
