namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedItem2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Items", "Location_Longitude");
            DropColumn("dbo.Items", "Location_Latitude");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Location_Latitude", c => c.Single(nullable: false));
            AddColumn("dbo.Items", "Location_Longitude", c => c.Single(nullable: false));
        }
    }
}
