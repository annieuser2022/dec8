using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("CustomerIndex");
        }
        public IActionResult CustomerIndex()
        {
            return View("CustomerIndex");
        }
    }
}
