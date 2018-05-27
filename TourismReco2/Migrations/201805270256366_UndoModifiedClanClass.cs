namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UndoModifiedClanClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clans", "ClanPreference", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clans", "ClanPreference");
        }
    }
}
