//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNum { get; set; }
        public void BookRoom(Room room)
        {
            room.BookRoom();
            Console.WriteLine($"Room is booked: {room.GetDetails()}");
        }

        public void CancelBooking(Room room)
        {
            room.Return();
            Console.WriteLine($"Room booking is cancelled: {room.GetDetails()}");
        }
    }


}