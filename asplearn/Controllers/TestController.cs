using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
 
namespace asplearn.Controllers
{
    public class TestController : Controller
    {
        [HttpGet] // This is like Post == "GET"
        [Route("")] // This is where you would route
        public IActionResult Index()
        {
            return View("Index"); // Looks in Views\Test\ folder for index.cshtml
        }

    }
}
