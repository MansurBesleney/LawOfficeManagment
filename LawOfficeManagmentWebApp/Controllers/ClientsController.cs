using Microsoft.AspNetCore.Mvc;

namespace LawOfficeManagmentWebApp.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
