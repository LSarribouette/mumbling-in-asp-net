using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dojo.Domain.Entities;
using Dojo.Domain.Services;
using X.PagedList;
using Dojo.Web.ViewModels;
using Dojo.Web.Mappings;

namespace Dojo.Web.Controllers
{
    public class SamouraisController : Controller
    {
        private readonly SamouraiService _samouraiService;
        private readonly ArmeService _armeService;
        private readonly ArtMartialService _artMartialService;

        public SamouraisController(SamouraiService samouraiService, ArmeService armeService, ArtMartialService artMartialService)
        {
            _samouraiService = samouraiService;
            _armeService = armeService;
            _artMartialService = artMartialService;
        }

        // GET: Samourais
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(_samouraiService.FetchAllPaged(pageNumber, pageSize));
        }

        // GET: Samourais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_samouraiService.FindById(id.Value));
        }

        // GET: Samourais/Create
        public IActionResult Create()
        {
            SamouraiVM samouraiVM = SamouraiMapping.ToVM(new Samourai(), _armeService.FetchAll(), _artMartialService.FetchAll());
            return View(samouraiVM);
        }

        // POST: Samourais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SamouraiVM samouraiVM)
        {
            if (ModelState.IsValid)
            {
                _samouraiService.Create(SamouraiMapping.ToModel(samouraiVM, _armeService.FetchAll(), _artMartialService.FetchAll()));
                return RedirectToAction(nameof(Index));
            }
            return View(samouraiVM);
        }

        // GET: Samourais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            SamouraiVM samouraiVM = SamouraiMapping.ToVM(_samouraiService.FindById(id.Value), _armeService.FetchAll(), _artMartialService.FetchAll());
            if (samouraiVM == null)
            {
                return NotFound();
            }
            return View(samouraiVM);
        }

        // POST: Samourais/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SamouraiVM samouraiVM)
        {
            if (id != samouraiVM.Samourai.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _samouraiService.Edit(SamouraiMapping.ToModel(samouraiVM, _armeService.FetchAll(), _artMartialService.FetchAll()));
                return RedirectToAction(nameof(Index));
            }
            return View(samouraiVM);
        }

        // GET: Samourais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var samourai = _samouraiService.FindById(id.Value);
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
                _samouraiService.Delete(samourai);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
