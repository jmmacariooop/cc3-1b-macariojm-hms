//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class HotelSystem
    {
        private List<Room> _availableRooms;
        private List<Room> _bookedRooms;

        public HotelSystem()
        {
            _availableRooms = new List<Room>();
            _bookedRooms = new List<Room>();
        }

        public void AddAvailRoom(Room room)
        {
            _availableRooms.Add(room);
        }
        public void BookRoom(Room room, Customer customer)
        {
            if (room.Available)
            {
                customer.BookRoom(room);
                _bookedRooms.Add(room);
                _bookedRooms.Remove(room);
            }
            else
            {
                Console.WriteLine("Room is already booked.");
            }
        }
        public void DisplayAvailableRooms()
        {
            Console.WriteLine("Available Rooms:");
            foreach (Room room in _availableRooms)
            {
                Console.WriteLine("\t" + room.GetDetails());
            }
        }
        public void DisplayBookedRooms()
        {
            Console.WriteLine("Booked Rooms:");
            foreach (Room room in _bookedRooms)
            {
                Console.WriteLine("\t" + room.GetDetails());
            }
        }


    }
}
