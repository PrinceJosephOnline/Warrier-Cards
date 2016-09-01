using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("seller_payments")]
    public partial class SellerPayment
    {

        [Column("transaction_id")]
        [Required]
        [Key]
        public int TransactionId { get; set; }

        [Column("seller_id")]
        [Required]
        public int SellerId { get; set; }

        [Column("order_id")]
        public Nullable<int> OrderId { get; set; }

        [Column("invoice_id")]
        [StringLength(20)]
        public string InvoiceId { get; set; }

        [Column("total_amount")]
        [Required]
        public double TotalAmount { get; set; }

        [Column("seller_fee_amount")]
        [Required]
        public double SellerFeeAmount { get; set; }

        [Column("seller_fee_criteria")]
        [Required]
        [StringLength(100)]
        public string SellerFeeCriteria { get; set; }

        [Column("transaction_date")]
        [Required]
        public DateTime TransactionDate { get; set; }

        [Column("author_id")]
        [Required]
        public int AuthorId { get; set; }

        [Column("details")]
        [StringLength(200)]
        public string Details { get; set; }

        [ForeignKey("Seller")]

        public virtual Seller Seller { get; set; }
        [ForeignKey("Order")]

        public virtual Order Order { get; set; }

    }
}
