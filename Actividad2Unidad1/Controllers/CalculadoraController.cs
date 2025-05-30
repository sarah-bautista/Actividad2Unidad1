using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(double valor1, double valor2, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "suma":
                    resultado = valor1 + valor2;
                    break;
                case "resta":
                    resultado = valor1 - valor2;
                    break;
                case "multiplicacion":
                    resultado = valor1 * valor2;
                    break;
                case "division":
                    resultado = valor2 != 0 ? valor1 / valor2 : 0;
                    break;
            }

            ViewBag.Resultado = resultado;
            return View("Resultado");
        }
    }
}