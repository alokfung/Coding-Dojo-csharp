using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
 
namespace portfolio.Controllers // rename with {project_name}.Controllers
{
    public class MainController : Controller // rename with {this_controller} : Controller
    {
        [HttpGet]
        [Route("home")]
        public IActionResult Index()
        {
            return View("Index"); // Looks in Views\{this_controller}\ folder for index.cshtml
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult Projects()
        {
            return View("projects"); // Looks in Views\{this_controller}\ folder for index.cshtml
        }

        [HttpGet]
        [Route("contacts")]
        public IActionResult Contacts()
        {
            return View("contacts"); // Looks in Views\{this_controller}\ folder for index.cshtml
        }


    }
}