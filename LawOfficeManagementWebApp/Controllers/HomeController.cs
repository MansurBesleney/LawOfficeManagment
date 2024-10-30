using Microsoft.AspNetCore.Mvc;

namespace LawOfficeManagementWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
