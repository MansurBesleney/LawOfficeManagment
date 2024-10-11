using LawOfficeManagmentWebApp.Models;
using LawOfficeManagmentWebApp.Models.Dtos;
using LawOfficeManagmentWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LawOfficeManagmentWebApp.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

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
        public async  Task<IActionResult> Create(ClientDto client)
        {
            await _clientService.CreateClientAsync(client);
            return RedirectToAction(nameof(Index));
        }
    }
}
