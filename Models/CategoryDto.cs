namespace RaceDayApi.Models
{
    public class CategoryDto
    {
        public string CategoryName { get; set; }
        public decimal EntryFee { get; set; }
        public decimal DistanceKm { get; set; }
        public int EventID { get; set; }
    }
}