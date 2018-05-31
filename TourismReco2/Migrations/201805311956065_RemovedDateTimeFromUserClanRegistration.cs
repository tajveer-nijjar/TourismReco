namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDateTimeFromUserClanRegistration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserClanRegisterations", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserClanRegisterations", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
