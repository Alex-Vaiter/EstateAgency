namespace EstateAgency.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idClient { get; set; }

        [StringLength(80)]
        public string firstName { get; set; }

        [StringLength(80)]
        public string middleName { get; set; }

        [StringLength(80)]
        public string lastName { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(80)]
        public string email { get; set; }
    }
}
