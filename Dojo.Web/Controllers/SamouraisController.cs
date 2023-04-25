using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dojo.Domain.Entities;
using Dojo.Domain.Services;
using X.PagedList;

namespace Dojo.Web.Controllers
{
    public class SamouraisController : Controller
    {
        private readonly SamouraiService _samouraiService;

        public SamouraisController(SamouraiService samouraiService)
        {
            _samouraiService = samouraiService;
        }

        // GET: Samourais
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(_samouraiService.GetAllSamouraisPaged(pageNumber, pageSize));
        }

        // GET: Samourais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samourai = _samouraiService.GetSamouraiById(id.Value);

            return View(samourai);
        }

        // GET: Samourais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Samourais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Samourai samourai)
        {
            if (ModelState.IsValid)
            {
                _samouraiService.CreateSamourai(samourai);
                return RedirectToAction(nameof(Index));
            }
            return View(samourai);
        }

        // GET: Samourais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samourai = _samouraiService.GetSamouraiById(id.Value);
            if (samourai == null)
            {
                return NotFound();
            }
            return View(samourai);
        }

        // POST: Samourais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Samourai samourai)
        {
            if (id != samourai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _samouraiService.EditSamourai(samourai);
                return RedirectToAction(nameof(Index));
            }
            return View(samourai);
        }

        // GET: Samourais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samourai = _samouraiService.GetSamouraiById(id.Value);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // POST: Samourais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, Samourai samourai)
        {
            if (id != samourai.Id)
            {
                return NotFound();
            }

            if (samourai != null)
            {
                //_context.Samourai.Remove(samourai);
                _samouraiService.DeleteSamourai(samourai);
            }

            return RedirectToAction(nameof(Index));
        }

        //private bool SamouraiExists(int id)
        //{
        //    return (_context.Samourai?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
