using System.Collections.Generic;

namespace TourismReco2.Models
{
    public class Clan
    {
        public int ClanId { get; set; }
        public string ClanName { get; set; }
        public float? ClanPreference { get; set; }
        public List<SubClan> SubClans { get; set; }
    }
}