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

        private readonly JamesAmosDbContext _context;

        public VlogController(JamesAmosDbContext context)
        {
            _context = context;


        }

        /// <summary>
        /// Gets all vlogs from DB and orders them from newest to oldest
        /// </summary>
        /// <returns>view with vlogs</returns>
        public async Task<IActionResult> Index()
        {
            var vlogs = _context.Vlogs.OrderByDescending(v => v.DateCreated).ToList();

            return View(vlogs);
        }

        /// <summary>
        /// sends admin to create new vlog post page
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Creates new vlos post
        /// </summary>
        /// <param name="Subject"></param>
        /// <param name="VideoUrl"></param>
        /// <returns></returns>
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

        /// <summary>
        /// redirects to login page
        /// </summary>
        /// <returns>view</returns>
        public IActionResult Login()
        {
            return RedirectToAction("Login", "Account");
        }

        /// <summary>
        /// redirects to contact page
        /// </summary>
        /// <returns>view</returns>
        public IActionResult Contact()
        {
            return RedirectToAction("Contact", "Home");
        }

        /// <summary>
        /// Deletes a vlog post
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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