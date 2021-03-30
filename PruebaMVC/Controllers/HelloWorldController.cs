using Microsoft.AspNetCore.Mvc;

namespace PruebaMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int ID = 1)
        {
            //return "This is the Welcome action method...";
            ViewData["Mensaje"] = "Hola " + name;
            ViewData["Intentos"] = ID;
            return View();
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
