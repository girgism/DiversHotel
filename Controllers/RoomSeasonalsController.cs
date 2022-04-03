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
    public class RoomSeasonalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomSeasonalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoomSeasonals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RoomSeasonals.Include(r=>r.Room).Include(r => r.Season);
            return View(await applicationDbContext.ToListAsync());

        }

        // GET: RoomSeasonals/Details/5
        public async Task<IActionResult> Details(RoomSeasonal roomSeason)
        {
            if (roomSeason == null)
            {
                return NotFound();
            }

            var roomSeasonal = await _context.RoomSeasonals
                .Include(r => r.Season)
                .Include(r =>r.Room)
                .FirstOrDefaultAsync(m => m.RoomId == roomSeason.RoomId && m.SeasonId == roomSeason.SeasonId);
            if (roomSeasonal == null)
            {
                return NotFound();
            }

            return View(roomSeasonal);
        }
        // GET: RoomSeasonals/Create
        public IActionResult Create()
        {
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name");
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name");
            return View();
        }

        // POST: RoomSeasonals/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomId,SeasonId,Price")] RoomSeasonal roomSeasonal)
        {
            if (ModelState.IsValid)
            {

                try
                {
                    _context.Add(roomSeasonal);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {

                    TempData["Error"] = "Sorry this Room Exist";
                    return RedirectToAction(nameof(Create));
                }
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name", roomSeasonal.RoomId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name", roomSeasonal.SeasonId);
            return View(roomSeasonal);
        }

        // GET: RoomSeasonals/Edit/5
        public async Task<IActionResult> Edit(RoomSeasonal roomSeason)
        {
            if (roomSeason == null)
            {
                return NotFound();
            }

            var roomSeasonal = await _context.RoomSeasonals
               
                .FirstOrDefaultAsync(m => m.RoomId == roomSeason.RoomId && m.SeasonId == roomSeason.SeasonId);
            if (roomSeasonal == null)
            {
                return NotFound();
            }
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name", roomSeasonal.RoomId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name", roomSeasonal.SeasonId);
            return View(roomSeasonal);
        }

        // POST: RoomSeasonals/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,RoomSeasonal roomSeasonal)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomSeasonal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomSeasonalExists(roomSeasonal.RoomId, roomSeasonal.SeasonId))
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
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name", roomSeasonal.RoomId);
            ViewData["SeasonId"] = new SelectList(_context.Seasons, "ID", "Name", roomSeasonal.SeasonId);
            return View(roomSeasonal);
        }

        // GET: RoomSeasonals/Delete/5
        public async Task<IActionResult> Delete(RoomSeasonal roomSeason)
        {
            if (roomSeason == null)
            {
                return NotFound();
            }

            var roomSeasonal = await _context.RoomSeasonals
                .Include(r => r.Season)
                .Include(r=>r.Room)
                .FirstOrDefaultAsync(m => m.RoomId == roomSeason.RoomId && m.SeasonId == roomSeason.SeasonId);
            if (roomSeasonal == null)
            {
                return NotFound();
            }

            return View(roomSeasonal);
        }

        // POST: RoomSeasonals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(RoomSeasonal roomSeason)
        {
            var roomSeasonal = await _context.RoomSeasonals.FirstOrDefaultAsync(m => m.RoomId == roomSeason.RoomId && m.SeasonId == roomSeason.SeasonId);

            _context.RoomSeasonals.Remove(roomSeasonal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomSeasonalExists(int seasonID, int roomID)
        {
            return _context.RoomSeasonals.Any(e => e.RoomId == roomID && e.SeasonId == seasonID);
        }
    }
}
