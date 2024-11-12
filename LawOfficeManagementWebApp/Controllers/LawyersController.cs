using LawOfficeManagementWebApp.Data;
using LawOfficeManagementWebApp.Models.Dtos;
using LawOfficeManagementWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LawOfficeManagementWebApp.Controllers;

public class LawyersController : Controller
{
    private readonly ILawyerService _lawyerService;

    public LawyersController(ILawyerService lawyerService)
    {
        _lawyerService = lawyerService;
    }


    // GET
    public async Task<IActionResult> Index()
    {
        var lawyers = await _lawyerService.GetAllLawyersAsync();
        return View(lawyers);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(LawyerDto lawyer)
    {
        await _lawyerService.CreateLawyerAsync(lawyer);

        return RedirectToAction(nameof(Index));
    }
}