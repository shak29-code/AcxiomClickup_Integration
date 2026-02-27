using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using acxiom_clickup_webapp.Models;
using Microsoft.AspNetCore.Authorization;
using Application.Services;
namespace acxiom_clickup_webapp.Controllers;
public class HomeController : Controller
{
    private readonly IClickUpService _clickUpService;

    public HomeController(IClickUpService clickUpService)
    {
        _clickUpService = clickUpService;
    }
    [Authorize]
    public async Task<IActionResult> Index()
    {
        _clickUpService.GetTeamID("", "");
        return View();
    }


    [AllowAnonymous]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [AllowAnonymous]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
