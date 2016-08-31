using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("order_management")]
    public partial class OrderManagement
    {

        [Column("activity_id")]
        [Required]
        [Key]
        public int ActivityId { get; set; }

        [Column("order_id")]
        [Required]
        public int OrderId { get; set; }

        [Column("author_id")]
        [Required]
        public int AuthorId { get; set; }

        [Column("activity")]
        [Required]
        public int Activity { get; set; }

        [Column("details")]
        [StringLength(1000)]
        public string Details { get; set; }

        [Column("activity_date")]
        [Required]
        public DateTime ActivityDate { get; set; }

        [Column("activity_ip")]
        [StringLength(30)]
        public string ActivityIp { get; set; }

        [Column("is_moble_device")]
        [Required]
        public bool IsMobleDevice { get; set; }

        [Column("user_agent")]
        [StringLength(10)]
        public string UserAgent { get; set; }

        [ForeignKey("User")]

        public virtual User User { get; set; }
        [ForeignKey("Order")]

        public virtual Order Order { get; set; }

    }
}
