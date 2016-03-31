using _02EFDemoPro.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EFDemoPro.DAL
{
    #region
    /*
    public class EFContext:DbContext
    {
        public EFContext() : base("DefaultConnection") { }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(k => k.CategoryId)
                .Property(p => p.Description).IsRequired();
        }
    }
     * */
    #endregion

    public class EFContext : DbContext
    {
        public EFContext() : base("DefaultConnection") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(s => s.SubCategories)
                .WithRequired(c => c.Category)
                .HasForeignKey(f => f.CategoryId);

            modelBuilder.Entity<SubCategory>()
                .HasKey(k => k.SubCategoryId)
                .Property(p => p.SubCategoryName).IsRequired();
        }
    }
}
