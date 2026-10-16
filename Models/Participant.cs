using System;

namespace RaceDayApi.Models;

public class Participant
{
    public int ParticipantID { get; set; }
    public int UserID { get; set; }
    public string IDNumber { get; set; } = "";
    public string Phone { get; set; } = "";
    public string EmergencyContactName { get; set; } = "";
    public string EmergencyContactPhone { get; set; } = "";

    public User? User { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
        = new List<Enrollment>();
}