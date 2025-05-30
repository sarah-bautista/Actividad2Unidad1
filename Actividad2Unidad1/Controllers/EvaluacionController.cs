using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Resultado(int nota1, int nota2, int nota3, int nota4)
        {
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4.0;
            string estado;

            if (promedio >= 70)
                estado = "Aprobado";
            else if (promedio >= 60)
                estado = "En recuperación";
            else
                estado = "Reprobado";

            ViewBag.Promedio = promedio;
            ViewBag.Estado = estado;

            return View();
        }
    }
}