namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGeoPointToSelectedRecommendations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SelectedRecommendations", "GeoPoint_Lat", c => c.Double(nullable: false));
            AddColumn("dbo.SelectedRecommendations", "GeoPoint_Lng", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SelectedRecommendations", "GeoPoint_Lng");
            DropColumn("dbo.SelectedRecommendations", "GeoPoint_Lat");
        }
    }
}
