using System;

namespace RaceDayApi.Models;

public class Route
{
    public int RouteID { get; set; }
    public int EventID { get; set; }
    public decimal DistanceKm { get; set; }
    public int ElevationGainM { get; set; }
    public string StartPoint { get; set; } = "";
    public string FinishPoint { get; set; } = "";
    public string? RouteUrl { get; set; }

    public Event? Event { get; set; }
}