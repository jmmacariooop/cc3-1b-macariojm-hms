//New
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Room
    {
        public int RoomNum { get; set; }
        public double BookingPrice { get; set; }
        public bool Available { get; set; }

        public Room(int roomnum, double bookingprice, bool available)
        {
            RoomNum = roomnum;
            BookingPrice = bookingprice;
            Available = available;
        }
        public virtual string GetDetails()
        {
            return $"{RoomNum} {BookingPrice} ({Available})";
        }
        public void Rent()
        {
            Available = false;
        }
        public void Return()
        {
            Available = true;
        }
    }
}
