using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KickMe.Data.Models;

namespace KickMe.Data.EntityFramework
{
    public class KickMeContext : DbContext
    {
        public KickMeContext()
            : base("KickMeContext")
        {
            Database.SetInitializer<KickMeContext>(new KickMeInitializer());
        }

        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<ProjectItem> ProjectItems { get; set; }
        public DbSet<Commitment> Commitments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectAdmin> ProjectAdmins { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Models.Project>().MapToStoredProcedures();

            modelBuilder.Entity<Models.Project>().Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.ProjectItem>().Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.Commitment>().Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.Comment>().Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Models.Unit>().Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<ProjectAdmin>().HasKey(t => new { t.ProjectId, t.UserId });
        }
    }
}
