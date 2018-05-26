using System.Collections.Generic;

namespace TourismReco2.Models
{
    public class SubClan
    {
        public int SubClanId { get; set; }
        public string SubClanName { get; set; }
        public int SubClanPriority { get; set; }
        public List<Item> Items { get; set; }
        public int ClanId { get; set; }
        
    }
}