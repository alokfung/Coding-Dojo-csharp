using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
 
namespace timedisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet] // This is like Post == "GET"
        [Route("")] // This is where you would route
        public IActionResult Index()
        {
            return View("Index"); // Looks in Views\Test\ folder for index.cshtml
        }

    }
}