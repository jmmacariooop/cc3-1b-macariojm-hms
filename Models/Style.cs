//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Style : Room
    {
        internal static readonly string TwinRoom;
        internal static readonly string KingRoom;
        internal static readonly string QueenRoom;

        public Style(int roomnum, string style, double bookingprice, bool available ) : base(roomnum, style, bookingprice, available)
        {
        }
    }
}
