using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02EFDemoPro.Models;


namespace _02EFDemoPro.DAL
{
    public class SampleData:DropCreateDatabaseIfModelChanges<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            var categories = new List<Category>
            {
                new Category() { CategoryName = "MobilePhone", Description = "手机大类" },
                new Category() { CategoryName = "Computer", Description = "电脑大类" }
            };
            categories.ForEach(l => context.Categories.AddOrUpdate(c => c.CategoryId, l));
            context.SaveChanges();

            var subCategories = new List<SubCategory>
            {
                new SubCategory() { SubCategoryName = "2G", Category = context.Categories.Single(c => c.CategoryName == "MobilePhone") },
                new SubCategory() { SubCategoryName = "3G", Category = context.Categories.Single(c => c.CategoryName == "MobilePhone") },
                new SubCategory() { SubCategoryName = "4G", Category = context.Categories.Single(c => c.CategoryName == "MobilePhone") },
                new SubCategory() { SubCategoryName = "Desktop", Category = context.Categories.Single(c => c.CategoryName == "Computer") },
                new SubCategory() { SubCategoryName = "Laptop", Category = context.Categories.Single(c => c.CategoryName == "Computer") }
            };
            subCategories.ForEach(l => context.SubCategories.AddOrUpdate(s => s.SubCategoryId, l));
            context.SaveChanges();
        }
    }
}
