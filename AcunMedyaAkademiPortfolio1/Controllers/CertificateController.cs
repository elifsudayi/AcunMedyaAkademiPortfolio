using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class CertificateController : Controller
    {

        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();
        public ActionResult CertificateList()
        {
            var values = db.TblCertificate.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCertificate(TblCertificate p)
        {
            db.TblCertificate.Add(p);
            db.SaveChanges();
            return RedirectToAction("CertificateList");
        }
        public ActionResult DeleteCertificate(int id)
        {
            var values = db.TblCertificate.Find(id);
            db.TblCertificate.Remove(values);
            db.SaveChanges();
            return RedirectToAction("CertificateList");
        }
        [HttpGet]
        public ActionResult UpdateCertificate(int id)
        {
            var value = db.TblCertificate.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCertificate(TblCertificate p)
        {
            var value = db.TblCertificate.Find(p.CertificateID);
            value.Title = p.Title;
            value.ImageUrl = p.ImageUrl;
            value.CertificateNo = p.CertificateNo;
            value.SendDate = p.SendDate;         
            db.SaveChanges();
            return RedirectToAction("CertificateList");
        }
    }
}