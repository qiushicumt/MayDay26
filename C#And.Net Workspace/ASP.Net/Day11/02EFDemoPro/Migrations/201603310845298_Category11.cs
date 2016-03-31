namespace _02EFDemoPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Cate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Cate");
        }
    }
}
