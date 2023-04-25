using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dojo.Domain.Entities;
using Dojo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Dojo.Domain.Services;

namespace Dojo.Web.Controllers
{
    public class ArmesController : Controller
    {
        private readonly ArmeService _armeService;

        public ArmesController(ArmeService armeService)
        {
            _armeService = armeService;
        }

        // GET: Armes
        public async Task<IActionResult> Index()
        {
            return View(_armeService.FetchAll());
        }

        // GET: Armes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_armeService.FindById(id.Value));
        }

        // GET: Armes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Armes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Arme arme)
        {
            if (ModelState.IsValid)
            {
                _armeService.Create(arme);
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Armes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arme = _armeService.FindById(id.Value);
            if (arme == null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: Armes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Damage")] Arme arme)
        {
            if (id != arme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _armeService.Edit(arme);
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Armes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arme = _armeService.FindById(id.Value);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // POST: Armes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, Arme arme)
        {
            if (id != arme.Id)
            {
                return NotFound();
            }

            if (arme != null)
            {
                _armeService.Delete(arme);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
