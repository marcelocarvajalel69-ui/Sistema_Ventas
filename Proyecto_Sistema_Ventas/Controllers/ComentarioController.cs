using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Sistema_Ventas.Controllers
{
    public class ComentarioController : Controller
    {
        public IActionResult Comentarios()
        {
            return View();
        }
    }
}
