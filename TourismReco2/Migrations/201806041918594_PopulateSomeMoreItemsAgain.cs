namespace TourismReco2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSomeMoreItemsAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Te Anau Glowworm Caves', " +
                "'Lakefront Drive, Te Anau, Fiordland National Park, New Zealand', " +
                "4.5, 35)");

            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Lake Manowai', " +
                "'Lake Manowai Road | near Clifden, Tuatapere, New Zealand', " +
                "4, 35)");

            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Colac Bay', " +
                "'Colac Foreshore Road, 9881, New Zealand', " +
                "4.5, 35)");


            Sql("INSERT INTO Items (ItemName, ItemAddress, ItemRating, SubClanId) VALUES " +
                "('Te Anau Glowworm Caves', " +
                "'Lakefront Drive, Te Anau, Fiordland National Park, New Zealand', " +
                "4.5, 34)");
            
            
            
        }
        
        public override void Down()
        {
        }
    }
}
