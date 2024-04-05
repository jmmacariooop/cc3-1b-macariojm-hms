//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        private List<Room> Rooms { get; }


        public Hotel(string name, string location, string city, List<Room> rooms)
        {
            Name = name;
            Location = location;
            City = city;
            Rooms = rooms;

        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"Hotel {Name} - Available Rooms");
            foreach (var room in Rooms)
            {
                if (!room.Available)
                {
                    Console.WriteLine($"  Room {room.RoomNum}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Hotel {Name} - Booked Rooms");
            foreach (var room in Rooms)
            {
                if (room.Available)
                {
                    Console.WriteLine($"  Room {room.RoomNum}, Style: {room.Style}, Price: {room.BookingPrice}");
                }
            }
        }
    }
}
