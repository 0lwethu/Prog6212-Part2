namespace RaceDayApi.Models
{
    public class RouteDto
    {
        public string RouteName { get; set; }
        public decimal DistanceKm { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int EventID { get; set; }
    }
}