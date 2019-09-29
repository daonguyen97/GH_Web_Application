using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace GH_Web_Application.Models.DAO
{
    public class BookingDAO
    {
        public static Booking GetBooking(string bookingid)
        {
            string commandstr = "SELECT * FROM GH_BOOKING WHERE BOOKINGID = :BookingId";
            DataTable data = DbAccess.ExecuteQuery(commandstr, bookingid);

            return new Booking(data.Rows[0]);
        }
        public static IEnumerable<Booking> GetBookings(string userid)
        {
            List<Booking> bookings = new List<Booking>();

            string commandstr = "SELECT * FROM GH_BOOKING WHERE CUSTOMERID = :CustomerId";
            DataTable data = DbAccess.ExecuteQuery(commandstr,userid);
            foreach (DataRow item in data.Rows)
            {
                Booking booking = new Booking(item);
                bookings.Add(booking);
            }

            return bookings;
        }
        public static IEnumerable<Booking> GetAllBookings ()
        {
            List<Booking> bookings = new List<Booking>();

            string commandstr = "SELECT * FROM GH_BOOKING";
            DataTable data = DbAccess.ExecuteQuery(commandstr);
            foreach (DataRow item in data.Rows)
            {
                Booking booking = new Booking(item);
                bookings.Add(booking);
            }

            return bookings;
        }

        public static void CreateBooking(Booking booking)
        {
            string commandstr = "INSERT INTO GH_BOOKING(BOOKINGID,CATEGORYID,CUSTOMERID,BOOKINGTITLE,LOCATION,WORKINGDETAILS,PRICE,DATETIME)"
                               + "VALUES (SEQ_BOOKINGID.NEXTVAL, :CategoryID , :CustomerId , :BookingTitle , :Location , :WorkingDetails , :Price , :Datetime )";
            DbAccess.ExecuteNonQuery(commandstr, booking.CategoryId, booking.CustomerId, booking.BookingTitle, booking.Location, booking.WorkingDetail, booking.Price, booking.Date);
        }
        public static void UpdateBooking(Booking booking)
        {
            /*string commandstr = "UPDATE GH_BOOKING " +
                                "SET CATEGORYID = :CategoryId , "+
                                "BOOKINGTITLE = :BookingTitle , "+
                                "LOCATION = :Location " +
                                "WORKINGDETAILS = :WorkingDetails "+
                                "PRICE = :Price "+
                                "DATETIME = :Datetime "+
                                "WHERE BOOKINGID = :BookingId ";*/
            string commandstr = "UPDATE GH_BOOKING SET CATEGORYID = :CategoryID , BOOKINGTITLE = :BookingTitle , LOCATION = :Location , WORKINGDETAILS = :WorkingDetails , PRICE = :Price , DATETIME = :Datetime WHERE BOOKINGID = :BookingId";
            DbAccess.ExecuteNonQuery(commandstr, booking.CategoryId, booking.BookingTitle, booking.Location, booking.WorkingDetail, booking.Price, booking.Date.ToString("dd-MMM-yyyy"), booking.BookingId);           
        }
        public static void DeleteBooking(string BookingId)
        {
            string commandstr = "DELETE FROM GH_BOOKING WHERE BOOKINGID = :BookingId ";
            DbAccess.ExecuteNonQuery(commandstr, BookingId);
        }
    }
}
