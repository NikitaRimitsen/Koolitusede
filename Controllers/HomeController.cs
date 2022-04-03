using Koolitusede.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koolitusede.Controllers
{
    public class HomeController : Controller
    {
        //Koolitus kooli;
        Laps laps;
        Opetaja opetaja;
        Koolitus koolitus;
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            if (hour <= 16)
            {
                ViewBag.Greeting = hour < 10 ? "Tere hommikust!" : "Tere päevast";
            }
            else if (hour > 16)
            {
                ViewBag.Greeting = hour < 20 ? "Tere õhtu!" : "Tere öö";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //-----------------------------------------------------
        KoolitusContext db = new KoolitusContext();
        public ActionResult Koolitus()
        {
            IEnumerable<Koolitus> kooli = db.Koolituss;
            return View(kooli);
        }

        public ActionResult CreateKoolitus()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult CreateKoolitus(Koolitus koolitus)
        {
            db.Koolituss.Add(koolitus);
            db.SaveChanges();
            return RedirectToAction("Koolitus");
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeleteKoolitus(int Id)
        {
            Koolitus go = db.Koolituss.Find(Id);
            if (go == null)
            {
                return HttpNotFound();
            }
            return View(go);
        }
        [HttpPost, ActionName("DeleteKoolitus")]
        public ActionResult DeleteConfirmedK(int Id)
        {
            Koolitus go = db.Koolituss.Find(Id);
            if (go == null)
            {
                return HttpNotFound();
            }
            db.Koolituss.Remove(go);
            db.SaveChanges();
            return RedirectToAction("Koolitus");
            return View(go);
        }

        [HttpGet]
        [Authorize]
        public ActionResult EditKoolitus(int? id)
        {
            Koolitus go = db.Koolituss.Find(id);
            if (go == null)
            {
                return HttpNotFound();
            }
            return View(go);
        }
        [HttpPost, ActionName("EditKoolitus")]
        public ActionResult EditConfirmed(Koolitus koolitus)
        {
            db.Entry(koolitus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Koolitus");
        }




        //------------------------------------------------------
        [Authorize]
        public ActionResult Laps()
        {
            IEnumerable<Laps> laps = db.Lapss;
            return View(laps);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Createlaps()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createlaps(Laps laps)
        {
            db.Lapss.Add(laps);
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        [HttpGet]
        public ActionResult DeleteLaps(int Id)
        {
            Laps g = db.Lapss.Find(Id);
            if (g==null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost,ActionName("DeleteLaps")]
        public ActionResult DeleteConfirmed(int Id)
        {
            Laps g = db.Lapss.Find(Id);
            if (g == null)
            {
                return HttpNotFound();
            }
            db.Lapss.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Laps");
            return View(g);
        }

        [HttpGet]
        public ActionResult EditLaps(int? id)
        {
            Laps g = db.Lapss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("EditLaps")]
        public ActionResult EditConfirmed(Laps laps)
        {
            db.Entry(laps).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Laps");
        }
        //------------------------------------------------------
        //[Authorize]
        public ActionResult Opetaja()
        {
            IEnumerable<Opetaja> opetaja = db.Opetajas;
            return View(opetaja);
        }
        [Authorize]
        public ActionResult Createopetaja()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Createopetaja(Opetaja opetaja)
        {
            db.Opetajas.Add(opetaja);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        [HttpGet]
        [Authorize]
        public ActionResult DeleteOpetaja(int Id)
        {
            Opetaja go = db.Opetajas.Find(Id);
            if (go == null)
            {
                return HttpNotFound();
            }
            return View(go);
        }
        [HttpPost, ActionName("DeleteOpetaja")]
        public ActionResult DeleteConfirmedO(int Id)
        {
            Opetaja go = db.Opetajas.Find(Id);
            if (go == null)
            {
                return HttpNotFound();
            }
            db.Opetajas.Remove(go);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
            return View(go);
        }

        [HttpGet]
        [Authorize]
        public ActionResult EditOpetaja(int? id)
        {
            Opetaja go = db.Opetajas.Find(id);
            if (go == null)
            {
                return HttpNotFound();
            }
            return View(go);
        }
        [HttpPost, ActionName("EditOpetaja")]
        public ActionResult EditConfirmed(Opetaja opetaja)
        {
            db.Entry(opetaja).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }
    }
}