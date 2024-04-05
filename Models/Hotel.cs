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
        public List<Room> Room { get; set; }

        public Hotel(string name, string location, string city, List <Room>)
        {
            Name = name;
            Location = location;
            City = city;

        }
    }
}
