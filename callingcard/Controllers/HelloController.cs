using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
 
namespace callingcard.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello World!";
        }

        // Other code
        [HttpGet]
        [Route("/{first_name}/{last_name}/{age}/{color}")]
        public JsonResult Method(string first_name, string last_name, int age, string color)
        {
            return Json(new {First_Name = first_name, Last_Name = last_name, Age = age, Color = color});
        }
    }
}
