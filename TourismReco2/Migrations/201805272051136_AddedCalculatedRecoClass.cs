namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCalculatedRecoClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalculatedRecommendations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ItemId = c.Int(nullable: false),
                        SubClandId = c.Int(nullable: false),
                        CalcultedWeight = c.Double(nullable: false),
                        ChosenByUser = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalculatedRecommendations");
        }
    }
}
