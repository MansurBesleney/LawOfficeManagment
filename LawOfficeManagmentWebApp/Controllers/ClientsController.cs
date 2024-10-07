using LawOfficeManagmentWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LawOfficeManagmentWebApp.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var client = new Client();
            return View(client);
        }
    }
}
