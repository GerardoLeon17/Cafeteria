namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FiveMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderCode");
        }
    }
}
