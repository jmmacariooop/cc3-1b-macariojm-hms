//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public class Receptionist : Customer
    {
        public Receptionist(string name, string address, string email, string phonenum) : base(name, address, email, phonenum)
        {
        }

        public void BookReservation(Guest guest, Reservation reservation)
        {
            guest.Reservations.Add(reservation);
            reservation.Room.Available = true;
        }

        internal void BookReservation(Customer terry, Reservation res)
        {
            throw new NotImplementedException();
        }
    }
}
