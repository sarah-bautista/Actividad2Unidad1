using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Saludar(string nombre)
        {
            ViewBag.Mensaje = "Hola, " + nombre + " bienvenido a ASP.NET MVC";
            return View("Saludo");
        }
    }
}