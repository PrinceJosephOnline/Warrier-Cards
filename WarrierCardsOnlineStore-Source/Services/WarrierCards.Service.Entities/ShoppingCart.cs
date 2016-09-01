using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("shopping_cart")]
    public partial class ShoppingCart
    {

        [Column("cart_id")]
        [Required]
        [Key]
        public int CartId { get; set; }

        [Column("user_id")]
        [Required]
        public int UserId { get; set; }

        [Column("card_id")]
        [Required]
        public int CardId { get; set; }

        [Column("quantity")]
        [Required]
        public int Quantity { get; set; }

        [Column("is_shortlist_only")]
        [Required]
        public bool IsShortlistOnly { get; set; }

        [Column("added_datetime")]
        [Required]
        public DateTime AddedDatetime { get; set; }

        [ForeignKey("User")]

        public virtual User User { get; set; }
        [ForeignKey("Card")]

        public virtual Card Card { get; set; }

    }
}
