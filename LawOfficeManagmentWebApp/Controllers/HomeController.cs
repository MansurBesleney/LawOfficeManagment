using Microsoft.AspNetCore.Mvc;

namespace LawOfficeManagmentWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
