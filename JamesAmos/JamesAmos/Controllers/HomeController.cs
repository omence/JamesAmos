using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JamesAmos.Data;
using JamesAmos.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JamesAmos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmail _emailService;

        private readonly JamesAmosDbContext _context;

        public HomeController(JamesAmosDbContext context, IEmail emailService)
        {
            _context = context;

            _emailService = emailService;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vlog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(string email, string subject, string message)
        {
            if (email != null && subject != null && message != null)
            {
                await _emailService.SendEmail(email, subject, message);

                TempData["Message"] = "Sent, we will get back to you ASAP";

                return View();
            }

            return View();
        }
    }
}