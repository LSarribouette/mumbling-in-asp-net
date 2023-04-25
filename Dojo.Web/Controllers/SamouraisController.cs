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
        public async Task<IActionResult> Create([Bind("Id,Name,Strength")] Samourai samourai)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(samourai);
                //await _context.SaveChangesAsync();
                _samouraiService.CreateSamourai(samourai);
                Console.WriteLine("Un nouveau samourai a été créé : " + samourai.Name);
                return RedirectToAction(nameof(Index));
            }
            return View(samourai);
        }

        //// GET: Samourais/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Samourai == null)
        //    {
        //        return NotFound();
        //    }

        //    var samourai = await _context.Samourai.FindAsync(id);
        //    if (samourai == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(samourai);
        //}

        //// POST: Samourais/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Strength")] Samourai samourai)
        //{
        //    if (id != samourai.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(samourai);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SamouraiExists(samourai.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(samourai);
        //}

        //// GET: Samourais/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Samourai == null)
        //    {
        //        return NotFound();
        //    }

        //    var samourai = await _context.Samourai
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (samourai == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(samourai);
        //}

        //// POST: Samourais/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Samourai == null)
        //    {
        //        return Problem("Entity set 'DojoWebContext.Samourai'  is null.");
        //    }
        //    var samourai = await _context.Samourai.FindAsync(id);
        //    if (samourai != null)
        //    {
        //        _context.Samourai.Remove(samourai);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SamouraiExists(int id)
        //{
        //  return (_context.Samourai?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
