using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;
using Ahtapot_Recipe.ViewModel;

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
        if (ModelState.IsValid)
        {
            using (var db = new YemekDbContext())
            {
                db.Add(model);
                db.SaveChanges();
                return Content("Kullanıcı başarıyla kaydedildi.");
            }
        }
        else
        {
            return Content("Kullanıcı kaydedilemedi.");
        }
        //return RedirectToAction("Index", "Home");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login([FromForm] LoginViewModel model)
    {
        Console.WriteLine("50");
        if (ModelState.IsValid)
        {
            Console.WriteLine("53");
            using (var db = new YemekDbContext())
            {
                var kullanici = db.Kullanici.Where(t => t.Eposta == model.Eposta && t.Sifre == model.Sifre).ToList();
                Console.WriteLine("57");
                if (kullanici.Any())
                {
                    Console.WriteLine("60");
                    return Content("Giriş Yapıldı!");
                }
                else
                {
                    Console.WriteLine("64");
                   return Content("Giriş Yapılamadı. Eposta veya şifre yanlış.");
                }

            }
        }
        else
        {
            return Content("Hatalı format!");
        }


    }


}