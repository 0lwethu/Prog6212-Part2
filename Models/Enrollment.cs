using System;

namespace RaceDayApi.Models;

public class Enrollment
{
    public int EnrollmentID { get; set; }
    public int ParticipantID { get; set; }
    public int CategoryID { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;
    public string RaceNumber { get; set; } = "";
    public string Status { get; set; } = "Registered";

    public Participant? Participant { get; set; }
    public Category? Category { get; set; }
    public Result? Result { get; set; }
}