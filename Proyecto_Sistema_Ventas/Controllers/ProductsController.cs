using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Sistema_Ventas.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
