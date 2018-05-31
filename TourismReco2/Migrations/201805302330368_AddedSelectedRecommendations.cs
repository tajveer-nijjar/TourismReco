namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSelectedRecommendations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelectedRecommendations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ItemId = c.Int(nullable: false),
                        SubClandId = c.Int(nullable: false),
                        CalcultedWeight = c.Double(nullable: false),
                        ChosenByUser = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .Index(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SelectedRecommendations", "ItemId", "dbo.Items");
            DropIndex("dbo.SelectedRecommendations", new[] { "ItemId" });
            DropTable("dbo.SelectedRecommendations");
        }
    }
}
