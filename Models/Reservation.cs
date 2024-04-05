//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Reservation
    {
        private static int reservationCounter = 1234567890;
        public int ReservationNumber { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public Room Room { get; }

        public Reservation(DateTime startDate, DateTime endDate, Room room)
        {
            ReservationNumber = reservationCounter++;
            StartDate = startDate;
            EndDate = endDate;
            Room = room;
        }

        public override string ToString()
        {
            return $"Reservation Number: {ReservationNumber} Start Time: {StartDate}, End Time: {EndDate}, Duration: {(EndDate - StartDate).Days}, Total: {Room.BookingPrice}";
        }
    }
}
