namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateTimeToUserClanRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserClanRegisterations", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserClanRegisterations", "DateTime");
        }
    }
}
