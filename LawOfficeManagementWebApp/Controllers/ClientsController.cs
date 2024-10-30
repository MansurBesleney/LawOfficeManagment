using LawOfficeManagementWebApp.Models.Dtos;
using LawOfficeManagementWebApp.Services;
using LawOfficeManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LawOfficeManagementWebApp.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IActionResult> Index()
        {
            var clients = await _clientService.GetAllClientsAsync();

            return View(clients);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ClientDto client)
        {
            if (ModelState.IsValid)
            {
                await _clientService.UpdateClientAsync(client);  // Update the client
                return RedirectToAction(nameof(Index));
            }
            
            return View(client);

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

        public async Task<IActionResult> Delete(Guid id)
        {
            await _clientService.DeleteClientAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
