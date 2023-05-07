using Microsoft.AspNetCore.Mvc;

namespace WebToy.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
