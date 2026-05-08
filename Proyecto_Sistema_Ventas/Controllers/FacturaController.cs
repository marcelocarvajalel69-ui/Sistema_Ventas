using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Sistema_Ventas.Controllers
{
    public class FacturaController : Controller
    {
        public IActionResult Facturas()
        {
            return View();
        }
    }
}
