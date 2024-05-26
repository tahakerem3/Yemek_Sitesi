using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;

namespace Ahtapot_Recipe.Controllers;

public class NavbarController : Controller
{
    private readonly ILogger<NavbarController> _logger;

    public NavbarController(ILogger<NavbarController> logger)
    {
        _logger = logger;
    }

    public IActionResult Hakkimizda()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(KullaniciModel model)
    {
        return View();
    }

    public IActionResult Iletisim()
    {
        return View();
    }

   
}