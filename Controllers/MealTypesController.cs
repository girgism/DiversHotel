using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Divers_Hotel.Data;
using Divers_Hotel.Models;
using Microsoft.AspNetCore.Authorization;

namespace Divers_Hotel.Controllers
{
    [Authorize]
    public class MealTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MealTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MealTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MealTypes.ToListAsync());
        }

        // GET: MealTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealType = await _context.MealTypes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mealType == null)
            {
                return NotFound();
            }

            return View(mealType);
        }

        // GET: MealTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MealTypes/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,MealPrice")] MealType mealType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mealType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mealType);
        }

        // GET: MealTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealType = await _context.MealTypes.FindAsync(id);
            if (mealType == null)
            {
                return NotFound();
            }
            return View(mealType);
        }

        // POST: MealTypes/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,MealPrice")] MealType mealType)
        {
            if (id != mealType.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mealType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealTypeExists(mealType.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mealType);
        }

        // GET: MealTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mealType = await _context.MealTypes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mealType == null)
            {
                return NotFound();
            }

            return View(mealType);
        }

        // POST: MealTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mealType = await _context.MealTypes.FindAsync(id);
            _context.MealTypes.Remove(mealType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealTypeExists(int id)
        {
            return _context.MealTypes.Any(e => e.ID == id);
        }
    }
}
