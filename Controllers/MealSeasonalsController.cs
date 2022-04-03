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
    public class MealSeasonalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MealSeasonalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MealSeasonals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MealSeasonals.Include(m => m.Meal).Include(m => m.Season);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MealSeasonals/Details/5
        public async Task<IActionResult> Details(MealSeasonal mealseasonal)
        {
            if (mealseasonal == null)
            {
                return NotFound();
            }

            var mealSeasonal = await _context.MealSeasonals
                .Include(m => m.Meal)
                .Include(m => m.Season)
                .FirstOrDefaultAsync(m => m.MealId == mealseasonal.MealId && m.SeasonId == mealseasonal.SeasonId);
            if (mealSeasonal == null)
            {
                return NotFound();
            }

            return View(mealSeasonal);
        }

        // GET: MealSeasonals/Create
        public IActionResult Create()
        {
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name");
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name");
            return View();
        }

        // POST: MealSeasonals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MealId,SeasonId,Price")] MealSeasonal mealSeasonal)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(mealSeasonal);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {

                    TempData["Error"] = "Sorry this Meal Exist";
                    return RedirectToAction(nameof(Create));
                }
               
                return RedirectToAction(nameof(Index));
            }
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name", mealSeasonal.MealId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name", mealSeasonal.SeasonId);
            return View(mealSeasonal);
        }

        // GET: MealSeasonals/Edit/5
        public async Task<IActionResult> Edit(MealSeasonal mealseasonal)
        {
            if (mealseasonal == null)
            {
                return NotFound();
            }

            var mealSeasonal = await _context.MealSeasonals
                .Include(e =>e.Meal)
                .Include(e=>e.Season).FirstOrDefaultAsync(m => m.MealId == mealseasonal.MealId && m.SeasonId == mealseasonal.SeasonId);
            if (mealSeasonal == null)
            {
                return NotFound();
            }
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name", mealSeasonal.MealId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name", mealSeasonal.SeasonId);
            return View(mealSeasonal);
        }

        // POST: MealSeasonals/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MealSeasonal mealSeasonal)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mealSeasonal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealSeasonalExists(mealSeasonal.MealId , mealSeasonal.SeasonId))
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
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name", mealSeasonal.MealId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name", mealSeasonal.SeasonId);
            return View(mealSeasonal);
        }

        // GET: MealSeasonals/Delete/5
        public async Task<IActionResult> Delete(MealSeasonal mealseasonal)
        {
            if (mealseasonal == null)
            {
                return NotFound();
            }

            var mealSeasonal = await _context.MealSeasonals
                 .Include(e => e.Meal)
                 .Include(e => e.Season).FirstOrDefaultAsync(m => m.MealId == mealseasonal.MealId && m.SeasonId == mealseasonal.SeasonId);
            if (mealSeasonal == null)
            {
                return NotFound();
            }

            return View(mealSeasonal);
        }


        // POST: MealSeasonals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(MealSeasonal mealSeason)
        {
            var mealSeasonal = await _context.MealSeasonals.FirstOrDefaultAsync(m => m.MealId == mealSeason.MealId && m.SeasonId == mealSeason.SeasonId);

            _context.MealSeasonals.Remove(mealSeasonal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
        private bool MealSeasonalExists(int seasonID, int mealID)
        {
            return _context.MealSeasonals.Any(e => e.SeasonId == seasonID && e.MealId == mealID);
        }
    }
}
