//new

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Guest : Customer
    {
        public int NumberofBookedRooms { get; set; }
        public Room(string RoomNum) : base(RoomNum)
        {
            NumberofBookedRooms = numberofbookedrooms;
        }
    }
}