namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedClanClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clans", "ClanPreference");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clans", "ClanPreference", c => c.Single());
        }
    }
}
