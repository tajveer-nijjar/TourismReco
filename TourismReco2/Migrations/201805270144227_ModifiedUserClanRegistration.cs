namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedUserClanRegistration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clans", "UserClanRegisteration_Id", "dbo.UserClanRegisterations");
            DropIndex("dbo.Clans", new[] { "UserClanRegisteration_Id" });
            AddColumn("dbo.UserClanRegisterations", "ClanId", c => c.Int(nullable: false));
            DropColumn("dbo.Clans", "UserClanRegisteration_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clans", "UserClanRegisteration_Id", c => c.Int());
            DropColumn("dbo.UserClanRegisterations", "ClanId");
            CreateIndex("dbo.Clans", "UserClanRegisteration_Id");
            AddForeignKey("dbo.Clans", "UserClanRegisteration_Id", "dbo.UserClanRegisterations", "Id");
        }
    }
}
