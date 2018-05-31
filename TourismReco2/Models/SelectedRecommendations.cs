namespace TourismReco2.Models
{
    public class SelectedRecommendation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int SubClandId { get; set; }


        public double CalcultedWeight { get; set; }

        public bool ChosenByUser { get; set; }


    }
}