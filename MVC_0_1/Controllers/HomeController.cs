using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_0_1.Models;

namespace MVC_0_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Generator generator = new Generator();
            ViewBag.Number = generator.ReturnNumber();
            return View();
        }
    }
}