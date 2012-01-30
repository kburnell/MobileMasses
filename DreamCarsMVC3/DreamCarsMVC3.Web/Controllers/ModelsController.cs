using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DreamCarsMVC3.Data.Context;
using DreamCarsMVC3.Models;

namespace DreamCarsMVC3.Web.Controllers {

    public class ModelsController : Controller {

        private readonly DataContext _context = new DataContext();

        public ViewResult Index() {
            return View(_context.Models.Include(model => model.Manufacturer).Include(model => model.AvailableEngines).ToList());
        }

        public ViewResult Details(long id) {
            Model model = _context.Models.Single(x => x.ModelId == id);
            return View(model);
        }
    }
}