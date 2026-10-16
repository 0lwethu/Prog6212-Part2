using System;

namespace RaceDayApi.Models;

public class Category
{
    public int CategoryID { get; set; }
    public int EventID { get; set; }
    public string CategoryName { get; set; } = "";
    public decimal DistanceKm { get; set; }
    public decimal EntryFee { get; set; }
    public int MaxParticipants { get; set; }

    public Event? Event { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
        = new List<Enrollment>();
}