using System.Data.Entity;
using System.Web.Mvc;
using DreamCarsMVC3.Data.Context;

namespace DreamCarsMVC3.Web.Controllers {

    public class HomeController : Controller {

        public HomeController() {
            Database.SetInitializer(new DataContextInitializer());
        }

        public ActionResult Index() {
            //Database.SetInitializer(new DataContextInitializer());
            //using (DataContext dc = new DataContext()) {
            //    IList<Manufacturer> manufacturers = dc.Manufacturers.ToList();
            //}
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About() {
            return View();
        }
    }
}