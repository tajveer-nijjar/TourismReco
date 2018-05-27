namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedCalculatedRecommendationClass : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.CalculatedRecommendations", "ItemId");
            AddForeignKey("dbo.CalculatedRecommendations", "ItemId", "dbo.Items", "ItemId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CalculatedRecommendations", "ItemId", "dbo.Items");
            DropIndex("dbo.CalculatedRecommendations", new[] { "ItemId" });
        }
    }
}
