using BestSellingProducts.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestSellingProducts.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBestSellingProductsDataSource DataSource;

        public HomeController(IBestSellingProductsDataSource dataSource)
        {
            this.DataSource = dataSource;
        }

        public ActionResult Index()
        {
            return View(DataSource.GetTopTen());
        }

        public ActionResult TopByCategory()
        {
            ViewBag.Message = "Your application description page.";

            return View(DataSource.GetTopFiveEveryCategory());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Iker Obregon Reigosa";

            return View();
        }
    }
}