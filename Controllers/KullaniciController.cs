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
    

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Post([FromForm] KullaniciModel model)
    {
        Console.WriteLine(model.Id.ToString());
        Console.WriteLine(model.Eposta.ToString());
        Console.WriteLine(model.Sifre.ToString());
        Console.WriteLine(model.Isim.ToString());
        Console.WriteLine(model.Soyisim.ToString());
        // if (ModelState.IsValid)
        // {
            using (var db = new YemekDbContext())
            {
                db.Kullanici.Add(model);
                db.SaveChanges();
                return Content("Kullanıcı başarıyla kaydedildi.");
            }
        // }
        // else
        // {
        //     return Content("Kullanıcı kaydedilemedi.");
        // }
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
        if (ModelState.IsValid)
        {
            using (var db = new YemekDbContext())
            {
                var kullanici = db.Kullanici.Where(t => t.Eposta == model.Eposta && t.Sifre == model.Sifre).ToList();
                if (kullanici.Any())
                {
                    return Content("Giriş Yapıldı!");
                }
                else
                {
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