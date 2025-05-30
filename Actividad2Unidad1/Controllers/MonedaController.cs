using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Convertir(decimal montoDOP, string divisa)
        {
            decimal resultado = 0;
            string simbolo = "";

            if (divisa == "USD")
            {
                resultado = montoDOP / 58;
                simbolo = "USD";
            }
            else if (divisa == "EUR")
            {
                resultado = montoDOP / 63;
                simbolo = "EUR";
            }

            ViewBag.Resultado = $"{resultado:F2} {simbolo}";
            return View("Resultado");
        }
    }
}
