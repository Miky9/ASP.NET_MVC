using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_0_2.Models;

namespace MVC_0_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            Calculator calculator = new Calculator();
            ViewBag.Name = name;
            return View(calculator);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost] // this method runs only after sending of form
        public IActionResult Index(Calculator calculator)
        {
            if (ModelState.IsValid)
            {
                calculator.Calculate();
            }

            return View(calculator);
        }
    }
}
