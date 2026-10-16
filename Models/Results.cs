using System;

namespace RaceDayApi.Models;

public class Result
{
    public int ResultID { get; set; }
    public int EnrollmentID { get; set; }
    public TimeSpan? FinishTime { get; set; }
    public int? Position { get; set; }
    public string ResultStatus { get; set; } = "Finished";
    public DateTime RecordedAt { get; set; } = DateTime.UtcNow;

    public Enrollment? Enrollment { get; set; }
}