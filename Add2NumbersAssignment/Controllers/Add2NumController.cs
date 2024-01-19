using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Add2NumbersAssignment.Models;
using System.Numerics;

namespace Add2NumbersAssignment.Controllers
{
    public class Add2NumController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Numbers number = new Numbers();
            return View(number);
        }
        
        [HttpPost]
        public IActionResult Index(Numbers numbers)
        {
            ViewBag.res = numbers.Num1 + numbers.Num2;
            return View();
        }
    }
}
