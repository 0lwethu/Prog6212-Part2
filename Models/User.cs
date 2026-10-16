using System;

namespace RaceDayApi.Models;

public class User
{
    public int UserID { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Role { get; set; } = "Participant";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Participant? Participant { get; set; }
    public Organiser? Organiser { get; set; }
}