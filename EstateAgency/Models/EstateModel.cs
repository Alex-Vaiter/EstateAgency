namespace EstateAgency.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EstateModel : DbContext
    {
        public EstateModel()
            : base("name=EstateModel")
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
