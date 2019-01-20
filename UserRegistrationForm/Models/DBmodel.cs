namespace UserRegistrationForm.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBmodel : DbContext
    {
        public DBmodel()
            : base("name=DBmodel")
        {
        }

        public virtual DbSet<MAS_USER> MAS_USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MAS_USER>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<MAS_USER>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
