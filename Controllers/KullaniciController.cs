using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;

namespace Ahtapot_Recipe.Controllers;

public class KullaniciController : Controller
{
    private readonly ILogger<KullaniciController> _logger;

    public KullaniciController(ILogger<KullaniciController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Post(KullaniciModel model)
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
}