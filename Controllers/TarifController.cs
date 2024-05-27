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
    public IActionResult YemekKaydet(TarifModel model)
    {
        using (var db = new YemekDbContext())
        {
            model.OlusturulmaTarihi = System.DateTime.Now;
            model.Olusturan = 1;
            db.Tarif.Add(model);
            db.SaveChanges();
            return Content("Yemek başarıyla kaydedildi.");
        }
    }

    public IActionResult Ekle()
    {
        return View();
    }


}