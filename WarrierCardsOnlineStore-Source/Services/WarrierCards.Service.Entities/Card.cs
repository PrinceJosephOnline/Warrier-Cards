using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("cards")]
    public partial class Card
    {

        [Column("card_id")]
        [Required]
        [Key]
        public int CardId { get; set; }

        [Column("card_name")]
        [Required]
        [StringLength(50)]
        public string CardName { get; set; }

        [Column("model_number")]
        [Required]
        [StringLength(50)]
        public string ModelNumber { get; set; }

        [Column("supplier_id")]
        [Required]
        public int SupplierId { get; set; }

        [Column("seller_id")]
        public Nullable<int> SellerId { get; set; }

        [Column("weight")]
        [Required]
        public double Weight { get; set; }

        [Column("dimension")]
        [Required]
        [StringLength(50)]
        public string Dimension { get; set; }

        [Column("type")]
        [Required]
        public bool Type { get; set; }

        [Column("orientation")]
        [Required]
        public bool Orientation { get; set; }

        [Column("printing_option")]
        [Required]
        [StringLength(100)]
        public string PrintingOption { get; set; }

        [Column("color")]
        [Required]
        [StringLength(200)]
        public string Color { get; set; }

        [Column("gsm")]
        [Required]
        public int Gsm { get; set; }

        [Column("original_price")]
        [Required]
        public double OriginalPrice { get; set; }

        [Column("selling_price")]
        [Required]
        public double SellingPrice { get; set; }

        [Column("description")]
        [StringLength(2000)]
        public string Description { get; set; }

        [Column("available_quantity")]
        [Required]
        public int AvailableQuantity { get; set; }

        [Column("keywords")]
        [StringLength(2000)]
        public string Keywords { get; set; }

        [Column("is_active")]
        public Nullable<bool> IsActive { get; set; }

        [ForeignKey("Seller")]

        public virtual Seller Seller { get; set; }
        [ForeignKey("Supplier")]

        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
