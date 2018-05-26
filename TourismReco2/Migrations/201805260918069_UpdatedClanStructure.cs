namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedClanStructure : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clans", "ClanPreference", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clans", "ClanPreference", c => c.Single(nullable: false));
        }
    }
}
