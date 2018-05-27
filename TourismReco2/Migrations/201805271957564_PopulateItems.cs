namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateItems : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Faith in Fiordland', '85 Lakefront Drive, Te Anau, Fiordland National Park 9600, New Zealand', 5, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
