using GamesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Input(int? Id)
        {
            ProductInputViewModel viewModel = new ProductInputViewModel();
            return PartialView(viewModel);
        }

        [HttpPost]
        public ActionResult Input(ProductInputViewModel ViewModel)
        {
            if(ModelState.IsValid)
            {

            }
            return PartialView();
        }

        public ActionResult Category()
        {
            return PartialView();
        }

        public ActionResult File()
        {
            return PartialView();
        }

        public ActionResult OperatingSystem()
        {
            return PartialView();
        }
    }
}