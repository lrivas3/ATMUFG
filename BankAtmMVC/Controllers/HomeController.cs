using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAtmMVC.Models;
using Microsoft.AspNetCore.Authorization;
using BankAtmMVC.Data;
using System.Security.Claims;

namespace BankAtmMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var currentId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = db.AspNetUsers.FirstOrDefault(i => i.Id == currentId);

            if (user != null)
            {
                return View(user);
            }
            else
            {
                return NotFound(); 
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
