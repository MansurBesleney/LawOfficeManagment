using Microsoft.AspNetCore.Mvc;

namespace LawOfficeManagmentWebApp.Controllers;

public class LawyersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}