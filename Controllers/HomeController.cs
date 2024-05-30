using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;

namespace Ahtapot_Recipe.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Anasayfa()
    {
        return View();
    }
    public IActionResult Hakkimizda()
    {
        return View();
    }
    public IActionResult Iletisim()
    {
        return View();
    }
    public IActionResult Ekle()
    {
        return View();
    }
    public IActionResult Tarifler()
    {
        return View();
    }
   





    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
