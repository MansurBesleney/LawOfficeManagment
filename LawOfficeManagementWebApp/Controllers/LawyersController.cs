using LawOfficeManagementWebApp.Data;
using LawOfficeManagementWebApp.Models.Dtos;
using LawOfficeManagementWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LawOfficeManagementWebApp.Controllers;

public class LawyersController : Controller
{
    private readonly IClientService _clientService;

    public LawyersController(IClientService clientService)
    {
        _clientService = clientService;
    }


    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var clients = await _clientService.GetAllClientsAsync();
        
        ViewBag.Clients = clients;
        return View();
    }
}