using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("orders")]
    public partial class Order
    {

        [Column("order_id")]
        [Required]
        [Key]
        public int OrderId { get; set; }

        [Column("user_id")]
        [Required]
        public int UserId { get; set; }

        [Column("card_id")]
        [Required]
        public int CardId { get; set; }

        [Column("quantity")]
        [Required]
        public int Quantity { get; set; }

        [Column("address_id")]
        [Required]
        public int AddressId { get; set; }

        [Column("is_print_requested")]
        public Nullable<bool> IsPrintRequested { get; set; }

        [Column("total_amount")]
        public Nullable<int> TotalAmount { get; set; }

        [Column("payment_status")]
        [Required]
        public bool PaymentStatus { get; set; }

        [Column("payment_mode")]
        public Nullable<bool> PaymentMode { get; set; }

        [Column("payment_txn_id")]
        [StringLength(80)]
        public string PaymentTxnId { get; set; }

        [Column("is_samplekit")]
        [Required]
        public bool IsSamplekit { get; set; }

        [ForeignKey("ShippingAddress")]

        public virtual ShippingAddress ShippingAddress { get; set; }
        [ForeignKey("Card")]

        public virtual Card Card { get; set; }

        public virtual ICollection<SellerPayment> SellerPayments { get; set; }

        public virtual ICollection<OrderManagement> OrderManagements { get; set; }

        public virtual ICollection<OrderCustomization> OrderCustomizations { get; set; }

    }
}
