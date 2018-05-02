using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        // Inside your Controller class
        // Other code

        // A GET method
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello World!";
        }

        // A POST method
        [HttpPost]
        [Route("")]
        public string Other()
        {
            // Return a view (We'll learn how soon!)
            return "This is the regular path";
        }

        // Illustrates that you can use parameters on routing
        [HttpGet]
        [Route("template/{Name}")]
        public IActionResult Method(string Name)
        {
            // Method body
            return null;
        }


    }
}
