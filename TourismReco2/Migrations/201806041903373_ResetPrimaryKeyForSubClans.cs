namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetPrimaryKeyForSubClans : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('SubClans', RESEED, 1)");
        }

        public override void Down()
        {
        }
    }
}
