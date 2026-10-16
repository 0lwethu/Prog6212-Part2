using System;

namespace RaceDayApi.Models;

public class Organiser
{
    public int OrganiserID { get; set; }
    public int UserID { get; set; }
    public string OrganisationName { get; set; } = "";
    public string Phone { get; set; } = "";

    public User? User { get; set; }
    public ICollection<Event> Events { get; set; }
        = new List<Event>();
}