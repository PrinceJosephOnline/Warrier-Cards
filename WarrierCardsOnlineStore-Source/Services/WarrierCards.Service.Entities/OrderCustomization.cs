using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("order_customization")]
    public partial class OrderCustomization
    {

        [Column("customization_id")]
        [Required]
        [Key]
        public int CustomizationId { get; set; }

        [Column("order_id")]
        [Required]
        public int OrderId { get; set; }

        [Column("content_type")]
        [Required]
        public int ContentType { get; set; }

        [Column("custom_content")]
        [Required]
        [StringLength(4000)]
        public string CustomContent { get; set; }

        [ForeignKey("Order")]

        public virtual Order Order { get; set; }

    }
}
