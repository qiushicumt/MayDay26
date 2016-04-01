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
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(s => s.SubCategories)
                .WithRequired(c => c.Category)
                .HasForeignKey(f => f.CategoryId);
            modelBuilder.Entity<Category>()
                .HasKey(k => k.CategoryId)
                .Property(c => c.CategoryName).IsRequired().HasMaxLength(20);

            modelBuilder.Entity<SubCategory>()
                .HasKey(k => k.SubCategoryId)
                .Property(p => p.SubCategoryName).IsRequired();

            modelBuilder.Entity<Product>()
                .HasKey(k => k.ProductId)
                .Property(p => p.ProductName).IsRequired().HasMaxLength(120);

            modelBuilder.Entity<SubCategory>()
                .HasMany(c => c.Products)
                .WithMany(s => s.SubCategories)
                .Map(t => t.MapLeftKey("SubCategoryId").MapRightKey("ProductId").ToTable("SubcategoryProduct"));
                
        }
    }
}
