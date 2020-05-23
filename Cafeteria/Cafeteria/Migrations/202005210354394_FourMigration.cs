namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.Binary());
            DropColumn("dbo.Products", "ImgUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ImgUrl", c => c.String());
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
