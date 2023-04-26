using Dojo.Domain.Entities;
using Dojo.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dojo.Web.Controllers
{
    public class ArtsMartiauxController : Controller
    {

        private readonly ArtMartialService _artMartialService;

        public ArtsMartiauxController(ArtMartialService artMartialService)
        {
            _artMartialService = artMartialService;
        }

        // GET: Armes
        public async Task<IActionResult> Index()
        {
            return View(_artMartialService.FetchAll());
        }

        // GET: Armes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_artMartialService.FindById(id.Value));
        }

        // GET: Armes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Armes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtMartial artMartial)
        {
            if (ModelState.IsValid)
            {
                _artMartialService.Create(artMartial);
                return RedirectToAction(nameof(Index));
            }
            return View(artMartial);
        }

        // GET: Armes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artMartial = _artMartialService.FindById(id.Value);
            if (artMartial == null)
            {
                return NotFound();
            }
            return View(artMartial);
        }

        // POST: Armes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Damage")] ArtMartial artMartial)
        {
            if (id != artMartial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _artMartialService.Edit(artMartial);
                return RedirectToAction(nameof(Index));
            }
            return View(artMartial);
        }

        // GET: Armes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var artMartial = _artMartialService.FindById(id.Value);
            if (artMartial == null)
            {
                return NotFound();
            }

            return View(artMartial);
        }

        // POST: Armes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, ArtMartial artMartial)
        {
            if (id != artMartial.Id)
            {
                return NotFound();
            }

            if (artMartial != null)
            {
                _artMartialService.Delete(artMartial);
            }

            return RedirectToAction(nameof(Index));
        }

        //// GET: ArtsMartiauxController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: ArtsMartiauxController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: ArtsMartiauxController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ArtsMartiauxController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ArtsMartiauxController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: ArtsMartiauxController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: ArtsMartiauxController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: ArtsMartiauxController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
