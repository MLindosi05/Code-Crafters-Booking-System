using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Crafters_Booking_System
{
    public static class UserSession
    {
        public static int ClientID;
        public static int BookingID;
        public static String BookingReference;
        public static String GuestName;
        public static String EmailAddress;
        public static String PhysicalAddress;
        public static String TotalPrice;


        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string FullName { get; set; }
    }
}