using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explorer.web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login)
        {
            // TODO check login in database
            return RedirectToAction("Index");
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}