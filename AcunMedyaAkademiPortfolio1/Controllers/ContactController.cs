using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio1.Models;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class ContactController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();
        public ActionResult ContactList()
        { 
            var values = db.TblContact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.TblContact.Find(id);
            db.TblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult ShowContact(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult ShowContact(TblContact p)
        {
            var value = db.TblContact.Find(p.ContactID);
            value.NameSurname = p.NameSurname;
            value.Email = p.Email;
            value.Phone = p.Phone;
            value.Message = p.Message;
            value.SendDate = p.SendDate;
            value.IsRead = p.IsRead;
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}