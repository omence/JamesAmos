using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JamesAmos.Data;
using JamesAmos.Models;
using JamesAmos.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JamesAmos.Controllers
{
    public class VlogController : Controller
    {
        private readonly IEmail _emailService;

        private readonly JamesAmosDbContext _context;

        public VlogController(JamesAmosDbContext context, IEmail emailService)
        {
            _context = context;

            _emailService = emailService;

        }
        public async Task<IActionResult> Index()
        {
            var vlogs = _context.Vlogs.OrderByDescending(v => v.DateCreated).ToList();

            return View(vlogs);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(string Subject, string VideoUrl)
        {
            Vlog vlog = new Vlog();

            vlog.DateCreated = DateTime.Now;

            vlog.Subject = Subject;

            vlog.VideoUrl = VideoUrl;

            _context.Vlogs.Add(vlog);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Contact()
        {
            return RedirectToAction("Contact", "Home");
        }

        [Authorize]
        public IActionResult Delete(int ID)
        {
            var toDelete = _context.Vlogs.FirstOrDefault(d => d.ID == ID);

            if (toDelete != null)
            {
                 _context.Remove(toDelete);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}