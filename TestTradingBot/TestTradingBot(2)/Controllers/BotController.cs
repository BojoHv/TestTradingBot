using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTradingBot_2_.Controllers
{
    public class BotController : Controller
    {
        List<Models.Bot> Bots = new List<Models.Bot>
        {
            new Models.Bot(1, 1000, 0.5, DateTime.Today),
            new Models.Bot(2, 3000, 0.2, DateTime.Today),
            new Models.Bot(3, 2500, 0.7, DateTime.Today)
        };
        // GET: BotController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BotController/Details/5
        public ActionResult Details(int id)
        {
            //return View();
            Models.Bot bot = Bots[id];
            return View(bot);
        }

        // GET: BotController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BotController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Bots.Add(new Models.Bot(Bots);
            }
            catch
            {
                return View();
            }
        }

        // GET: BotController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BotController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BotController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BotController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
