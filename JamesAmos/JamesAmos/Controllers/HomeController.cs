using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JamesAmos.Data;
using JamesAmos.Models;
using JamesAmos.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public async Task<IActionResult> Index()
        {
            var prayer = await DailyPrayer();

            return View(prayer);
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

        public IActionResult Login()
        {
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Vlog()
        {
            return RedirectToAction("Index", "Vlog");
        }

        public async Task<DailyPrayer> DailyPrayer()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    //call made to the api
                    client.BaseAddress = new Uri("http://quotes.rest/bible/ ");

                    var response = await client.GetAsync("vod.json");

                    response.EnsureSuccessStatusCode();


                    //Reades JSON file received from API
                    string result = await response.Content.ReadAsStringAsync();

                    dynamic prayer = JsonConvert.DeserializeObject(result);
                    //Build object
                    DailyPrayer dailyPrayer = new DailyPrayer();

                    dailyPrayer.Verse = prayer.contents.verse;
                    dailyPrayer.Book = prayer.contents.book;
                    dailyPrayer.Chapter = prayer.contents.chapter;
                    dailyPrayer.Number = prayer.contents.number;

                    return dailyPrayer;
                }
                catch
                {
                    DailyPrayer dailyPrayer2 = new DailyPrayer();

                    dailyPrayer2.Verse = "For I know the plans I have for you,” declares the LORD, “plans to prosper you and not to harm you, plans to give you hope and a future.";
                    dailyPrayer2.Book = "Jeremiah";
                    dailyPrayer2.Chapter = "29";
                    dailyPrayer2.Number = "11";

                    return dailyPrayer2;
                }
            }
        }
    }
}