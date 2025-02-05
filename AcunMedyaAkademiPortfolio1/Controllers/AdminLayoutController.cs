using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio1.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult _SidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptsPartial()
        {
            return PartialView();
        }
    }
}