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
    [ValidateAntiForgeryToken]
    public IActionResult Post([FromForm] KullaniciModel model)
    {
        Console.WriteLine(model);
        if (ModelState.IsValid)
        {
            Console.WriteLine("28. satır çalıştı");
            using (var db = new YemekDbContext())
            {
                Console.WriteLine("31");
                db.Add(model);
                db.SaveChanges();
                return Content("Kullanıcı başarıyla kaydedildi.");
            }           
        }
        else{
            return Content("Kullanıcı kaydedilemedi.");
        }
        //return RedirectToAction("Index", "Home");

    }

    public IActionResult Privacy()
    {
        return View();
    }


}