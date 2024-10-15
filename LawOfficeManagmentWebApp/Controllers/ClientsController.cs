﻿using LawOfficeManagmentWebApp.Models;
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

        public async Task<IActionResult> Index()
        {
            var clients = await _clientService.GetAllClientsAsync();

            return View(clients);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
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
    }
}
