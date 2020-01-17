namespace EstateAgency.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAgent { get; set; }

        [Required]
        [StringLength(80)]
        public string firstName { get; set; }

        [Required]
        [StringLength(80)]
        public string middleName { get; set; }

        [Required]
        [StringLength(80)]
        public string lastName { get; set; }

        public int? dealShare { get; set; }
    }
}
