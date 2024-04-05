//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class HotelManagementSystem
    {
        private List<Hotel> Hotels { get; }

        public HotelManagementSystem()
        {
            Hotels = new List<Hotel>();
        }

        public void AddHotel(
            hotel)
        {
            Hotels.Add(hotel);
        }

        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in Hotels)
            {
                Console.WriteLine($"  {hotel.Name}, {hotel.Location}");
            }
        }

        public void BookReservation(Hotel hotel, Room room, Guest guest, DateTime startDate, DateTime endDate)
        {
            guest.MakeReservation(hotel, room, startDate, endDate);
        }

        public void RegisterUser(Customer user)
        {
            Console.WriteLine($"User {user.Name} registered.");
        }

        public void DisplayReservationDetails(int reservationNumber)
        {
            // Assuming this method displays the details of the reservation with the given number.
            Console.WriteLine($"Details of Reservation {reservationNumber}:");
            // Code to display reservation details goes here
        }

    }
}
