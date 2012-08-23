using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DreamCarsMVC4.Data.Context;
using DreamCarsMVC4.Models;

namespace DreamCarsMVC4.Web.Controllers {

    public class ManufacturersController : Controller {

        private readonly DataContext _context = new DataContext();

        public ManufacturersController() {
            Database.SetInitializer(new DataContextInitializer());
        }

        public ViewResult Index() {
            return View(_context.Manufacturers.Include(manufacturer => manufacturer.Models).ToList());
        }

        public ViewResult Details(long id) {
            Manufacturer manufacturer = _context.Manufacturers.Single(x => x.ManufacturerId == id);
            return View(manufacturer);
        }
    }
}