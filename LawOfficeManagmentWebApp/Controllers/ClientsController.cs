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

            var client = new Client
            {
                ClientId = id.HasValue?id.Value:0,
                ClientTcNumber = "56459584587",
                ClientName = "Mansur",
                ClientSurname = "Besleney",
                ClientGSM = "5387612894"
            };
            return View(client);
        }
    }
}
