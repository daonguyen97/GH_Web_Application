using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace GH_Web_Application.Models
{
    public class Booking
    {
        public string BookingId { get; set; }
        public string CategoryId { get; set; }
        public string CustomerId { get; set; }
        public string HandymanId { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Price { get; set; }
        public string BookingTitle { get; set; }
        public string WorkingDetail { get; set; }
        public string State { get; set; }

        //Constructor
        public Booking()
        {

        }
        
        public Booking(DataRow row)
        {
            BookingId = row["BOOKINGID"].ToString();
            CategoryId = row["CATEGORYID"].ToString();
            CustomerId = row["CUSTOMERID"].ToString();
            HandymanId = row["HANDYMANID"].ToString();
            Location = row["LOCATION"].ToString();
            Date = Convert.ToDateTime(row["DATETIME"].ToString());
            Price = row["PRICE"].ToString();
            BookingTitle = row["BOOKINGTITLE"].ToString();
            WorkingDetail = row["WORKINGDETAILS"].ToString();
            State = row["STATE"].ToString();
        }
    }
}
