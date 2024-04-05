//new

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Guest : Customer
    {
        public List<Reservation> Reservations { get; }

        public Guest(string name, string address, string email, string phonenum) : base(name, address, email, phonenum)
        {
            Reservations = new List<Reservation>();
        }

        public void MakeReservation(Hotel hotel, Room room, DateTime startDate, DateTime endDate)
        {
            var reservation = new Reservation(startDate, endDate, room);
            Reservations.Add(reservation);
            room.Available = true;
        }

        public void DisplayReservations()
        {
            Console.WriteLine($"List of Reservations of {Name}:");
            foreach (var reservation in Reservations)
            {
                Console.WriteLine($"  {reservation}");
            }
        }
    }
}