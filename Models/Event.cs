using System;

namespace RaceDayApi.Models;

public class Event
{
    public int EventID { get; set; }
    public int OrganiserID { get; set; }
    public string EventName { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime EventDate { get; set; }
    public TimeSpan StartTime { get; set; }
    public string Location { get; set; } = "";
    public string Status { get; set; } = "Upcoming";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Organiser? Organiser { get; set; }
    public ICollection<Category> Categories { get; set; }
        = new List<Category>();
    public Route? Route { get; set; }
}