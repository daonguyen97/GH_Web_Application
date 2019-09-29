using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GH_Web_Application.Models;
using Oracle.ManagedDataAccess.Client;
using GH_Web_Application.Models.DAO;
using System.Diagnostics;

namespace GH_Web_Application.Controllers
{
    public class BookingController : Controller
    {
        public UserAccount CurUser = HomeController.CurUser;
        
        public BookingController()
        {
            //CurUser = HomeController.CurUser;
        }

        public IActionResult Index()
        {
            ViewBag.Name = CurUser.Name;
            return View(BookingDAO.GetAllBookings());
        }
        public IActionResult CreateBooking()
        {
            ViewBag.Name = CurUser.Name;
            return View();
        }

        [HttpGet]

        public IActionResult BookingDetails(string BookingId)
        {
            ViewBag.Name = CurUser.Name;
            return View(BookingDAO.GetBooking(BookingId));
        }

        public IActionResult EditBooking(string BookingId)
        {
            return View("EditBooking",BookingDAO.GetBooking(BookingId));
        }

        [HttpPost]
        public IActionResult CreateNewBooking(Booking booking)
        {
            ViewBag.Name = CurUser.Name;
            booking.CustomerId = CurUser.UserId;
            booking.State = "Pending";
            BookingDAO.CreateBooking(booking);
            return View("Index", BookingDAO.GetBookings(CurUser.UserId));
        }

        public IActionResult UpdateBooking(Booking booking)
        {
            BookingDAO.UpdateBooking(booking);
            return View("BookingDetails",BookingDAO.GetBooking(booking.BookingId));
        }

        public IActionResult DeleteBooking(Booking booking)
        {
            BookingDAO.DeleteBooking(booking.BookingId);
            return View("Index",BookingDAO.GetBookings(CurUser.UserId));
        }
    }
}