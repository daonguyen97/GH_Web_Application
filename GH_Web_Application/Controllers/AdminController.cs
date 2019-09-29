using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GH_Web_Application.Models;
using GH_Web_Application.Models.DAO;

namespace GH_Web_Application.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Booking()
        {
            return View("BookingManagement", BookingDAO.GetAllBookings());
        }
        public IActionResult Feedback()
        {
            return View("FeedbackManagement", FeedbackDAO.GetAllFeedbacks());
        }
        public IActionResult Account()
        {
            return View("AccountManagement", UserAccountDAO.GetAccounts());
        }
    }
}