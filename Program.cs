using System.Collections;
using System.Collections.Generic;
using HOTEL_MANAGEMENT_SYSTEM.Models;


namespace CC3_1N_HMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> yananRooms = new List<Room>();
            Room room1 = new Room(101, Style.TwinRoom, 1500);
            Room room2 = new Room(102, Style.KingRoom, 3000);
            yananRooms.Add(room1);
            yananRooms.Add(room2);
            Hotel hotelYanan = new Hotel("Hotel Yanan", "123 GStreet, Takaw City", yananRooms);

            List<Room> hotel456Rooms = new List<Room>();
            Room hotel456Room1 = new Room(101, Style.QueenRoom, 2000);
            Room hotel456Room2 = new Room(102, Style.QueenRoom, 2000);
            hotel456Rooms.Add(hotel456Room1);
            hotel456Rooms.Add(hotel456Room2);
            Hotel hotel456 = new Hotel("Hotel 456", "Session Road, Baguio City", hotel456Rooms);

            HotelManagementSystem hms = new HotelManagementSystem(); 
            hms.AddHotel(hotelYanan);
            hms.AddHotel(hotel456);

            //Output of DisplayHotels
            //List of Hotels:
            //  Hotel Yanan, 123 GStreet, Takaw City
            //  Hotel 456, Session Road, Baguio City
            hms.DisplayHotels();

            //Output of DisplayAvailableRooms should look like
            //Hotel Hotel Yanan - Available Rooms
            //  Room 101, Style: TwinRoom, Price: 1500
            //  Room 102, Style: KingRoom, Price: 3000
            hotelYanan.DisplayAvailableRooms();

            Guest terry = ("Terry", "Addr 1", "terry@email.com", "63919129"); 
            hms.RegisterUser(terry);

            hms.BookReservation(hotelYanan, room1, terry, DateTime.Now, new DateTime(2024, 04, 16));

            //Output of DisplayBookedRooms should look like
            //Hotel Yanan - Booked Rooms
            //  Room 101, Style: TwinRoom, Price: 1500
            hotelYanan.DisplayBookedRooms();

            //Output of DisplayReservations
            //List of Reservations of Terry:
            //  1234567890 Start Time: 05 / 04 / 2024 4:17:07 pm, End Time: 16 / 04 / 2024 12:00:00 am, Duration: 10, Total: 1500016500
            terry.DisplayReservations();

            Receptionist anna = new Receptionist("Anna", "Addr 2", "anna@email.com", "67890");
            hms.RegisterUser(anna);

            Reservation res = new Reservation(new DateTime(2024, 05, 01), new DateTime(2024, 05, 06), hotel456Room2);
            anna.BookReservation(terry, res);

            //Output of
            //
            //List of Reservations of Terry:
            //    1234567890 Start Time: 05 / 04 / 2024 4:17:07 pm, End Time: 16 / 04 / 2024 12:00:00 am, Duration: 10, Total: 15000
            //    1234567891 Start Time: 01 / 05 / 2024 12:00:00 am, End Time: 06 / 05 / 2024 12:00:00 am, Duration: 5, Total: 10000
            terry.DisplayReservations();

            //Output:
            //1234567890 Start Time: 05/04/2024 4:27:49 pm, End Time: 16/04/2024 12:00:00 am, Duration: 10, Total: 15000
            hms.DisplayReservationDetails(1234567890);
        }
    }
}