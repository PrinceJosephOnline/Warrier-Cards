using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GenerateCodeFirstClass
{

    [Table("testimonials")]
    public partial class Testimonial
    {

        [Column("testimonial_id")]
        [Required]
        [Key]
        public int TestimonialId { get; set; }

        [Column("user_id")]
        public Nullable<int> UserId { get; set; }

        [Column("comments")]
        [StringLength(-1)]
        public string Comments { get; set; }

        [Column("rating")]
        public Nullable<int> Rating { get; set; }

        [ForeignKey("User")]

        public virtual User User { get; set; }

    }
}
