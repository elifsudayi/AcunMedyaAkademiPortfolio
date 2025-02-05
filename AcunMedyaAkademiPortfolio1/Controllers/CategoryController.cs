using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class CategoryController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();
        
        public ActionResult CategoryList()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TblCategory p)
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            db.TblCategory.Remove(values);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var value = db.TblCategory.Find(p.CategoryID);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

    }
}
