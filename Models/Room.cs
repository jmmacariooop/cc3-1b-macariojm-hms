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
        public int RoomNum { get; }
        public double BookingPrice { get; }
        public Style Style{ get; }
        public bool Available { get; set; }


        public Room(int roomnum, Style style, double bookingprice)
        {
            RoomNum = roomnum;
            Style = Style;
            BookingPrice = bookingprice;

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
