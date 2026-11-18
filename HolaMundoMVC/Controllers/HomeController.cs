
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensaje = "¡Hola Mundo desde ASP.NET MVC!";
            return View();
        }
    }
}
