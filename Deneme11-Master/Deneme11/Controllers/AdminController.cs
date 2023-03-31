using Deneme11.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deneme11.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir" , ag);
        }

        public ActionResult AnaSayfaGüncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.isim = x.isim;
            ag.profil = x.profil;
            ag.unvan = x.unvan;
            ag.aciklama = x.aciklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ikonListesi()
        {
            var deger = c.İkonlars.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }

       [HttpPost]
        public ActionResult YeniIkon(İkonlar p)
        {
            c.İkonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.İkonlars.Find(id);
            return View("ikonGetir", ig);
        }

        public ActionResult ikonGuncelle(İkonlar x)
        {
            var ig = c.İkonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.İkonlars.Find(id);
            c.İkonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
    }
}