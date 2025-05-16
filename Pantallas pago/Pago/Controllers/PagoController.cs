using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class PagoController : Controller
    {
        public IActionResult Index()
        {
            return View("Pago");
        }

        public IActionResult Confirmacion()
        {
            return View();
        }

        public IActionResult Agradecimiento()
        {
            return View();
        }
    }
}
