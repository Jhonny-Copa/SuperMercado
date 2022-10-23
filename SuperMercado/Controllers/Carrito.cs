using Microsoft.AspNetCore.Mvc;

namespace SuperMercado.Controllers
{
    public class Carrito : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
