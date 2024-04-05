//new
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGEMENT_SYSTEM.Models
{
    public abstract class Customer
    {
        public string Name { get; }
        public string Address { get; }
        public string Email { get; }
        public string PhoneNum { get; }


        protected Customer(string name, string address, string email, string phonemum)
        {
            Address = address;
            Name = name;
            PhoneNum = phonemum;
            Email = email;
        }
    }
}