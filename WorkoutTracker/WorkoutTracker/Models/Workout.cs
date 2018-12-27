using System;

namespace WorkoutTracker.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public int DistanceInMeters { get; set; }
        public long TimeInSeconds { get; set; }
    }
}
