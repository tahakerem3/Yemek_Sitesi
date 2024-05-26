using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;

namespace Ahtapot_Recipe.Controllers;

public class TariflerController : Controller
{
    private readonly ILogger<TariflerController> _logger;

    public TariflerController(ILogger<TariflerController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(KullaniciModel model)
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

   
}