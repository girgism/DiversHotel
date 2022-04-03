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
using Divers_Hotel.Services.GetTotaPrice;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace Divers_Hotel.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        public readonly ITotalReservationPrice _totalReservationPrice;

        private readonly ApplicationDbContext _context;
        public ReservationsController(ApplicationDbContext context, ITotalReservationPrice totalReservationPrice)
        {
            _context = context;
            _totalReservationPrice = totalReservationPrice;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reservations.Include(r => r.Meal).Include(r => r.Room);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Meal)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name");
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name");
            return View();
        }

        // POST: Reservations/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GuestName,GuestEmail,GuestCountry,NumberOfAdults,NumberOfChilds,CheckIn,CheckOut,MealId,RoomId")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //get the Total Price from Calcutation Function
                    double totalPrice = _totalReservationPrice.GetReservationTotal(reservation);

                    //Alert if the reservation Complited
                    TempData["GName"] = reservation.GuestName;
                    TempData["Price"] = JsonConvert.SerializeObject(totalPrice);

                    //Adding the total price To DB
                    reservation.TotalPrice = totalPrice;
                    _context.Add(reservation);

                }
                catch (Exception)
                {
                    //If Any Errors Catched
                    TempData["Error"] = "Sorry Meal Type Or Room Type not in the same season";
                    return RedirectToAction(nameof(Create));
                }

                //Save changes In DB
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name", reservation.MealId);
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name", reservation.RoomId);
            return View(reservation);

        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name", reservation.MealId);
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name", reservation.RoomId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GuestName,GuestEmail,GuestCountry,NumberOfAdults,NumberOfChilds,CheckIn,CheckOut,MealId,RoomId")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
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
            ViewData["MealId"] = new SelectList(_context.MealTypes, "ID", "Name", reservation.MealId);
            ViewData["RoomId"] = new SelectList(_context.RoomTypes, "ID", "Name", reservation.RoomId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Meal)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }


}
