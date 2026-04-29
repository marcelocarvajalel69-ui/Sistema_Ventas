using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Sistema_Ventas.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
