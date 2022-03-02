using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musteri_Bakiye_Seyri_.Models.Entity;


namespace Musteri_Bakiye_Seyri_.Controllers
{
    public class TanımController : Controller
    {
        MusteriDbEntities db = new MusteriDbEntities();
        // GET: Tanım
        public ActionResult Index()
        {
            var degerler = db.MUSTERİ_TANIM_TABLE.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult MusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MusteriEkle(MUSTERİ_TANIM_TABLE p1)
        {
            db.MUSTERİ_TANIM_TABLE.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}