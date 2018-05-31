namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovedGeoPointToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "GeoPoint_Lat", c => c.Double(nullable: false));
            AddColumn("dbo.Items", "GeoPoint_Lng", c => c.Double(nullable: false));
            DropColumn("dbo.SelectedRecommendations", "GeoPoint_Lat");
            DropColumn("dbo.SelectedRecommendations", "GeoPoint_Lng");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SelectedRecommendations", "GeoPoint_Lng", c => c.Double(nullable: false));
            AddColumn("dbo.SelectedRecommendations", "GeoPoint_Lat", c => c.Double(nullable: false));
            DropColumn("dbo.Items", "GeoPoint_Lng");
            DropColumn("dbo.Items", "GeoPoint_Lat");
        }
    }
}
