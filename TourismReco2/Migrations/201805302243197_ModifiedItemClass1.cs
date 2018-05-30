namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedItemClass1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CalculatedRecommendations", "ChosenByUser", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CalculatedRecommendations", "ChosenByUser", c => c.Boolean());
        }
    }
}
