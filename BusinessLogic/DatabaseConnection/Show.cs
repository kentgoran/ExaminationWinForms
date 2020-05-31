using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Show
    {
        public int ShowId { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public int RoomNumber { get; set; }
        public DateTime StartTime { get; set; }
        public bool GotWheelchairRamp { get; set; }
        public virtual List<Ticket> Tickets { get; set; }

        public override string ToString()
        {
            if(Movie != null)
            {
                return $"{Movie.Name}, Room {RoomNumber}, starts at {StartTime.Hour:00}:00";
            }
            return $"Room {RoomNumber}, starts at {StartTime.Hour:00}:00";
        }
    }
}
