using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo.Models;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PTBN(float a, float b)
        {
            if (Convert.ToBoolean(a))
            {         
                if (a != 0)
                {
                ViewBag.Result = $"Phương trình có nghiệm: x = {-b / a}";
                }
                else
                {
                ViewBag.Result = "Phương trình vô nghiệm!";
                }
            }
            return View();
        }

        public IActionResult PTBH(float a, float b, float c)
        {
            if (Convert.ToBoolean(a))
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        ViewBag.Result = "Phương trình vô nghiệm!";
            }
            else
            {
                ViewBag.Result = $"Phương trình có một nghiệm: x = {-c / b}";
            }
            }
             else
            {
                float delta = b * b - 4 * a * c;
                float x1;
                float x2;
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                ViewBag.Result = $"Phương trình có 2 nghiệm là: x1 = {x1}, x2 = {x2}";
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                ViewBag.Result = $"Phương trình có nghiệm kép: x1 = x2 = {x1}";
            }
            else
            {
                ViewBag.Result = "Phương trình vô nghiệm!";
            } 
        }
      }
    // ViewBag.Result = a;
        return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
