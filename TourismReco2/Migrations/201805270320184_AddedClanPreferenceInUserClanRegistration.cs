namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClanPreferenceInUserClanRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserClanRegisterations", "ClanPreference", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserClanRegisterations", "ClanPreference");
        }
    }
}
