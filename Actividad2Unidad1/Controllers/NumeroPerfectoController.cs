using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verificar(int numero)
        {
            bool esPerfecto = EsNumeroPerfecto(numero);
            ViewBag.Mensaje = esPerfecto ? "El número es perfecto." : "El número no es perfecto.";
            return View("Resultado");
        }

        private bool EsNumeroPerfecto(int numero)
        {
            if (numero <= 0) return false;

            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                    suma += i;
            }

            return suma == numero;
        }
    }
}

