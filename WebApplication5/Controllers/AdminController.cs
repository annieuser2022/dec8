using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View("AdminIndex");
        }
        public IActionResult adminIndex()
        {
            return View("AdminIndex");
        }
    }
}
