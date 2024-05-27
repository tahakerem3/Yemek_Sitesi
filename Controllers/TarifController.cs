using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ahtapot_Recipe.Models;
using Microsoft.EntityFrameworkCore;

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
        using (var db = new YemekDbContext())
        {
            var tarif = db.Tarif.ToList();
            return View(tarif);
        }
    }
    [HttpPost]
    public IActionResult YemekKaydet(TarifModel model)
    {
        using (var db = new YemekDbContext())
        {
            model.OlusturulmaTarihi = System.DateTime.Now;
            model.Olusturan = 1;
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



    public IActionResult Sil(int id)
    {
        using (var db = new YemekDbContext())
        {
            var tarif = db.Tarif.Where(t => t.Id == id).FirstOrDefault();
            if (tarif != null)
            {
                db.Remove(tarif);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}