using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTradingBot1.Controllers
{
    public class RequestsController : Controller
    {
        // GET: RequestsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RequestsController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                return View();
            }
        }

        // GET: RequestsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequestsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Request id)
        {
            //public async Task<IActionResult> Create(Models.Request id)
            //{
            //    var request = new Models.Request();
            //    request.id = int.Parse(Models.Bot);
            //    request.initAmount = Models.Bot;
            //    request.currAmount = Models.Bot;

            //    request.tradePercent = Models.Bot;
            //    request.dateOfCreation = Models.Bot;
                
            //    return View(request);
        }

        // GET: RequestsController/Edit/5
        public ActionResult Edit(int id)
        {
                if (id == null)
                {
                    return NotFound();
                }
                return View();
        }

        // POST: RequestsController/Edit/5
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

        // GET: RequestsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RequestsController/Delete/5
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
