using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Sistema_Ventas.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
