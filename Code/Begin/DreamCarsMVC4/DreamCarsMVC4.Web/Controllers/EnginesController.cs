using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using DreamCarsMVC4.Data.Context;
using DreamCarsMVC4.Models;

namespace DreamCarsMVC4.Web.Controllers {

    public class EnginesController : Controller {

        private readonly DataContext _context = new DataContext();

        public ViewResult Index() {
            return View(_context.Engines.Include(engine => engine.AvailableOn).ToList());
        }

        public ViewResult Details(long id) {
            Engine engine = _context.Engines.Single(x => x.EngineId == id);
            return View(engine);
        }
    }
}