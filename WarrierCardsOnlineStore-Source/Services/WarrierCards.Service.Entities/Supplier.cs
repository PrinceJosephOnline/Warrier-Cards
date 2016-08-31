using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("suppliers")]
    public partial class Supplier
    {

        [Column("supplier_id")]
        [Required]
        [Key]
        public int SupplierId { get; set; }

        [Column("supplier_name")]
        [Required]
        [StringLength(200)]
        public string SupplierName { get; set; }

        [Column("supplier_address")]
        [StringLength(200)]
        public string SupplierAddress { get; set; }

        [Column("supplier_district")]
        [StringLength(20)]
        public string SupplierDistrict { get; set; }

        [Column("supplier_state")]
        [StringLength(20)]
        public string SupplierState { get; set; }

        [Column("supplier_country")]
        [StringLength(20)]
        public string SupplierCountry { get; set; }

        [Column("supplier_pincode")]
        [StringLength(10)]
        public string SupplierPincode { get; set; }

        [Column("supplier_email")]
        [StringLength(200)]
        public string SupplierEmail { get; set; }

        [Column("supplier_phone1")]
        [StringLength(12)]
        public string SupplierPhone1 { get; set; }

        [Column("supplier_phone2")]
        [StringLength(12)]
        public string SupplierPhone2 { get; set; }

        [Column("supplier_website")]
        [StringLength(10)]
        public string SupplierWebsite { get; set; }

        [Column("details")]
        [StringLength(200)]
        public string Details { get; set; }


        public virtual ICollection<Card> Cards { get; set; }

    }
}
