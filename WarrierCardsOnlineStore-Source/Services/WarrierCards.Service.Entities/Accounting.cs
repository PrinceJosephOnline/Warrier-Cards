using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("accounting")]
    public partial class Accounting
    {

        [Column("accounting_id")]
        [Required]
        public int AccountingId { get; set; }

        [Column("particulars")]
        [Required]
        [StringLength(200)]
        public string Particulars { get; set; }

        [Column("amount")]
        [Required]
        public double Amount { get; set; }

        [Column("is_debit")]
        [Required]
        public bool IsDebit { get; set; }

        [Column("description")]
        [Required]
        [StringLength(800)]
        public string Description { get; set; }


    }
}
