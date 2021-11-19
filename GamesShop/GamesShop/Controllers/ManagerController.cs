using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GamesShop.Models;
using Ninject;

namespace GamesShop.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return PartialView();
        }

        public ActionResult Categories()
        {
            return PartialView();
        }

        public ActionResult Developers()
        {
            return PartialView();
        }
     
        public ActionResult Publishers()
        {
            return PartialView();
        }

        public ActionResult OperatingSystems()
        {
            ApplicationDbContext Context = new ApplicationDbContext();
            return PartialView(Context.OperatingSystems.ToList());
        }
    }
}