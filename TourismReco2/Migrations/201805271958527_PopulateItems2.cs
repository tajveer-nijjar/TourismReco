namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateItems2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Cruise Milford', " +
                "'Milford Sound 9679, New Zealand', " +
                "5, 2)");
            


//            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
//                "('', " +
//                "'', " +
//                "5, 9)");
            
            
            
            
        }
        
        public override void Down()
        {
        }
    }
}
