namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserClanRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserClanRegisterations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clans", "UserClanRegisteration_Id", c => c.Int());
            CreateIndex("dbo.Clans", "UserClanRegisteration_Id");
            AddForeignKey("dbo.Clans", "UserClanRegisteration_Id", "dbo.UserClanRegisterations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clans", "UserClanRegisteration_Id", "dbo.UserClanRegisterations");
            DropIndex("dbo.Clans", new[] { "UserClanRegisteration_Id" });
            DropColumn("dbo.Clans", "UserClanRegisteration_Id");
            DropTable("dbo.UserClanRegisterations");
        }
    }
}
