
using System;

namespace OnlineCabBooking.Models
{
    public class Ride
    {
        public int Id { get; set; }
        public int RiderId { get; set; }
        public int DriverId { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
        public double Fare { get; set; }
        public string Status { get; set; } // Requested, Accepted, OnTheWay, Completed
        public DateTime RideTime { get; set; }
    }
}
