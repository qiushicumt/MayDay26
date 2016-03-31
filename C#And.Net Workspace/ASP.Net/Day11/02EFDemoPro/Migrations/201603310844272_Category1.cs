namespace _02EFDemoPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "Cate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Cate", c => c.String());
        }
    }
}
