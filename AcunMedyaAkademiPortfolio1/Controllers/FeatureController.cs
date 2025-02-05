using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class FeatureController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();

        public ActionResult FeatureList()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public ActionResult DeleteFeature(int id)
        {
            var values = db.TblFeature.Find(id);
            db.TblFeature.Remove(values);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.TblFeature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(TblFeature p)
        {
            var value = db.TblFeature.Find(p.FeatureID);
            value.NameSurname = p.NameSurname;
            value.Description = p.Description;
            value.ProjectName = p.ProjectName;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}