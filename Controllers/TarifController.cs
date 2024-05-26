using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;

namespace Ahtapot_Recipe.Controllers;

public class TarifController : Controller
{
    private readonly ILogger<TarifController> _logger;

    public TarifController(ILogger<TarifController> logger)
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