using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verificar(string usuario, string contraseña)
        {
            if (usuario == "admin" && contraseña == "123456")
            {
                return RedirectToAction("Bienvenido");
            }
            else
            {
                ViewBag.Mensaje = "Usuario incorrecto";
                return View("Index");
            }
        }

        public ActionResult Bienvenido()
        {
            return View();
        }
    }
}

