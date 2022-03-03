using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musteri_Bakiye_Seyri_.Models.Entity;

namespace Musteri_Bakiye_Seyri_.Controllers
{
    public class FaturaController : Controller
    {
        MusteriDbEntities db = new MusteriDbEntities();
        // GET: Fatura
        public ActionResult Index()
        {
            var degerler = db.MUSTERİ_FATURA_TABLE.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult FaturaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FaturaEkle(MUSTERİ_FATURA_TABLE p1)
        {
            db.MUSTERİ_FATURA_TABLE.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FaturaById(int id)
        {
            //var listelenecek = db.MUSTERİ_FATURA_TABLE.Single(user => user.MUSTERİ_ID == id);
            //var degerler = db.MUSTERİ_FATURA_TABLE.;
            var List = db.MUSTERİ_FATURA_TABLE.SqlQuery("Select * From MUSTERİ_FATURA_TABLE Where MUSTERİ_ID = " + id).ToList();
            return View(List);
        }
    }
}