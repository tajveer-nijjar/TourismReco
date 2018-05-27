using System.Collections.Generic;

namespace TourismReco2.Models
{
    public class Clan
    {
        public int ClanId { get; set; }
        public string ClanName { get; set; }
        public double? ClanPreference { get; set; }

        public bool IsSelected { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        
        public List<SubClan> SubClans { get; set; }
    }
}