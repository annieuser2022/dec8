using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static string adminId = "admin@horizon.com";
        static string warehouseId = "warehouse@horizon.com";
        static string customerId = "customer@horizon.com";
        static IList<User> userList =new List<User> { };
        string adminPass="admin";
        string warehousePass = "warehouse";
        string customerPass = "customer";


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LogInPage()
        {
            return View();
        }

        public IActionResult SignUpPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult CheckCredentials(Login details) {



            // we will do a call to the db
            if (details.EmailId == adminId && details.Password == adminPass) {
                return RedirectToAction("adminIndex", "Admin");
            }
            if (details.EmailId == warehouseId && details.Password == warehousePass)
            {
                return RedirectToAction("WarehouseIndex", "Warehouse");
            }
            if (details.EmailId == customerId && details.Password == customerPass)
            {
                return RedirectToAction("CustomerIndex","Customer");
            }
            foreach (var eachUser in userList)
            {
                if(eachUser.EmailId == details.EmailId && eachUser.Password ==
                    details.Password)
                {
                    if(eachUser.Role == "Customer")
                    {
                        return RedirectToAction("CustomerIndex","Customer");
                    }
                    else if(eachUser.Role == "Admin")
                    {
                        return RedirectToAction("adminIndex", "Admin");
                    }
                    else if(eachUser.Role == "Warehouse")
                    {
                        return RedirectToAction("WarehouseIndex", "Warehouse");
                    }
                    

                }
            }
            ViewBag.prompt = "Invalid email, or password, try again..";
            return View("LogInPage");
        }
       
        public IActionResult SignupUser(User details)
        {
            Random Id = new Random();
            int userId = Id.Next(1, 10000);
            details.Id = userId;
            userList.Add(details);
            ViewBag.details= details;
            return View("UserCreated");
        }

    }
}