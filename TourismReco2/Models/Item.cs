namespace TourismReco2.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public ItemType? ItemType { get; set; }

        public string ItemAddress { get; set; }
        public GeoPoint GeoPoint { get; set; }

        public string ItemDescription { get; set; }

        public float ItemRating { get; set; }

//        public Location Location { get; set; }

        public int SubClanId { get; set; }
    }
}