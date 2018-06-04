namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDateTimeToUserClanRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserClanRegisterations", "DateTimeDayOfTheYear", c => c.Int(nullable: false));
            DropColumn("dbo.UserClanRegisterations", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserClanRegisterations", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserClanRegisterations", "DateTimeDayOfTheYear");
        }
    }
}
