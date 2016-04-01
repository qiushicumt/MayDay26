namespace _02EFDemoPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.SubcategoryProduct",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SubCategoryId, t.ProductId })
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.SubCategoryId)
                .Index(t => t.ProductId);
            
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubcategoryProduct", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SubcategoryProduct", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.SubcategoryProduct", new[] { "ProductId" });
            DropIndex("dbo.SubcategoryProduct", new[] { "SubCategoryId" });
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            DropTable("dbo.SubcategoryProduct");
            DropTable("dbo.Products");
        }
    }
}
