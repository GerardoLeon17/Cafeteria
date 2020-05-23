namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImgUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ImgUrl");
        }
    }
}
