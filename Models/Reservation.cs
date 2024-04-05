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
        public int reservationNum { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateOnly duration { get; set; }


    }
}
