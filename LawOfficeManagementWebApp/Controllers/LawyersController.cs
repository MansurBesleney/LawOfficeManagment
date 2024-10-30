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
    public IActionResult Create()
    {
        return View();
    }
}