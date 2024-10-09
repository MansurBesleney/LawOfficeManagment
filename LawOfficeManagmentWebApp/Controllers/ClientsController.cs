using LawOfficeManagmentWebApp.Models;
using LawOfficeManagmentWebApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LawOfficeManagmentWebApp.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientDto client)
        {
            return View(client);
        }
    }
}
