using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verificar(int numero)
        {
            bool esPrimo = EsPrimo(numero);
            ViewBag.Mensaje = esPrimo ? "El número es primo." : "El número no es primo.";
            return View("Resultado");
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
