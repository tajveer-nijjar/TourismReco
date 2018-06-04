namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetPrimaryKey : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT('Clans', RESEED, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
