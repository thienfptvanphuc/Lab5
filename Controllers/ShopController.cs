using Microsoft.AspNetCore.Mvc;

namespace Lab5.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
