using Ahtapot_Recipe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace Ahtapot_Recipe.Controllers;

public class TarifController : Controller
{
    private readonly ILogger<TarifController> _logger;

    public TarifController(ILogger<TarifController> logger)
    {
        _logger = logger;
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
    public IActionResult Index()
    {
        if (!string.IsNullOrEmpty(HttpContext.Session.GetString("Id")))
        {
            using (var db = new YemekDbContext())
            {
                var tarif = db.Tarif.ToList();
                return View(tarif);
            }
        }
        return View();       
    }
    [HttpPost]
    public IActionResult YemekKaydet(TarifModel model, IFormFile file)
    {
        var dosyaIsimi = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);
        using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
        {
            file.CopyToAsync(stream);
        }
         
        using (var db = new YemekDbContext())
        {
            model.OlusturulmaTarihi = System.DateTime.Now;
            model.Olusturan = 1;
            model.YemekFoto = dosyaIsimi;
            db.Tarif.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

    public IActionResult Ekle()
    {
        return View();
    }


    public IActionResult Duzenle(int id)
    {
        using (var db = new YemekDbContext())
        {
            var tarif = db.Tarif.Where(t => t.Id == id).FirstOrDefault();
            return View(tarif);
        }

    }


    [HttpPost]
    public IActionResult Duzenle(TarifModel model)
    {
        using (var db = new YemekDbContext())
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }


    public IActionResult Sil(int Id)
    {
        using (var db = new YemekDbContext())
        {
            var tarif = db.Tarif.Where(t => t.Id == Id).FirstOrDefault();
            if (tarif != null)
            {
                db.Remove(tarif);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }

    
    public IActionResult TarifSil(int id)
    {
        using (var db = new YemekDbContext())
        {
            var tarif = db.Tarif.Where(t => t.Id == id).FirstOrDefault();
            return View("Sil",tarif);
        }
    }

}