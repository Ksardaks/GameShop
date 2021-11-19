using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesShop.Controllers
{
    public class PublisherController : Controller
    {
        // GET: Publisher
        public ActionResult Input(int? Id)
        {
            return PartialView();
        }
    }
}