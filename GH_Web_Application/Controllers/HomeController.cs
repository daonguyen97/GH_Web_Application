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
    public class HomeController : Controller
    {
        public static UserAccount CurUser { get; set; }


        public HomeController()
        {
            //connection.Open();
        }

        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]

        public IActionResult ListAccounts()
        {
            return View(UserAccountDAO.GetAccounts());
        }

        public IActionResult AccountDetail()
        {
             return View("AccountDetail", CurUser);
        }

        public IActionResult LoginApplication(UserAccount login)
        {
            try
            {
                CurUser = UserAccountDAO.GetAccount(login.EmailAddress,login.Password);
                ViewBag.Name = CurUser.Name;
                return View("Dashboard");
            }
            catch
            {
                return View("Login");
            }
        }

        [HttpPost]
        public IActionResult Register(UserAccount account)
        {
            UserAccountDAO.CreateAccount(account);
            return View("Login");
        }
        
    }
}