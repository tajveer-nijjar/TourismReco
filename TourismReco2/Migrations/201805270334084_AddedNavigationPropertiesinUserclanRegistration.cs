namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNavigationPropertiesinUserclanRegistration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserClanRegisterations", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserClanRegisterations", "UserId");
            CreateIndex("dbo.UserClanRegisterations", "ClanId");
            AddForeignKey("dbo.UserClanRegisterations", "ClanId", "dbo.Clans", "ClanId", cascadeDelete: true);
            AddForeignKey("dbo.UserClanRegisterations", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserClanRegisterations", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserClanRegisterations", "ClanId", "dbo.Clans");
            DropIndex("dbo.UserClanRegisterations", new[] { "ClanId" });
            DropIndex("dbo.UserClanRegisterations", new[] { "UserId" });
            AlterColumn("dbo.UserClanRegisterations", "UserId", c => c.String());
        }
    }
}
