using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class WarehouseController:Controller
    {
        public IActionResult Index()
        {
            return View("WarehouseIndex");
        }
        public IActionResult WarehouseIndex()
        {
            return View("WarehouseIndex");
        }

    }
}
