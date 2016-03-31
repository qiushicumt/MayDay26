using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using _02EFDemoPro.DAL;
using _02EFDemoPro.Models;

namespace _02EFDemoPro
{
    public class Program
    {
        static void Main(string[] args)
        {
            EFContext _dbContext = new EFContext();
            var categories = new List<Category>
            {
                new Category() { CategoryName = "MobilePhone", Description = "手机大类" },
                new Category() { CategoryName = "Computer", Description = "电脑大类" }
            };
            categories.ForEach(l => _dbContext.Categories.AddOrUpdate(c => c.CategoryId, l));
            _dbContext.SaveChanges();

            var subcategories = new List<SubCategory>
            {
                new SubCategory() { SubCategoryName = "2G", Category = _dbContext.Categories.Single(c => c.CategoryName == "MobilePhone") },
                new SubCategory() { SubCategoryName = "3G", Category = _dbContext.Categories.Single(c => c.CategoryName == "MobilePhone") },
                new SubCategory() { SubCategoryName = "4G", Category = _dbContext.Categories.Single(c => c.CategoryName == "MobilePhone") },
                new SubCategory() { SubCategoryName = "Desktop", Category = _dbContext.Categories.Single(c => c.CategoryName == "Computer") },
                new SubCategory() { SubCategoryName = "Laptop", Category = _dbContext.Categories.Single(c => c.CategoryName == "Computer") }
            };
            subcategories.ForEach(l => _dbContext.SubCategories.AddOrUpdate(s => s.SubCategoryId, l));
            _dbContext.SaveChanges();

            var categoryData = from s in _dbContext.Categories select s;
            foreach (var item in categoryData)
            {
                Console.WriteLine("类别：{0}，说明：{1}", item.CategoryName, item.Description);
            }
            Console.ReadKey();
        }
    }
}
