using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class TestimonialController : Controller
    {

        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();
        public ActionResult TestimonialList()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p)
        {
            db.TblTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial p)
        {
            var value = db.TblTestimonial.Find(p.TestimonialID);
            value.Title = p.Title;
            value.Description = p.Description;
            value.NameSurname = p.NameSurname;
            value.ImageUrl = p.ImageUrl;
            value.Job = p.Job;
            value.Status = p.Status;
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}