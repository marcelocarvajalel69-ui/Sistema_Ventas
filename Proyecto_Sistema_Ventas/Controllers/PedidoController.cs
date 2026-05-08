using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Sistema_Ventas.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Pedidos()
        {
            return View();
        }
    }
}
