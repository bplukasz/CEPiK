using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CEPiK.Models;
using Microsoft.AspNetCore.Mvc;

namespace CEPiK.Controllers
{
    public class VehicleCardsController : Controller
    {
        private readonly CepikContext _context;

        public VehicleCardsController(CepikContext context)
        {
            _context = context;
        }

        // GET: VehicleCards
        public async Task<IActionResult> Index(string searchString)
        {
            var cards = from m in _context.VehicleCards where m.SeriesAndNumber.Contains(searchString) select m;
            return View(await cards.ToListAsync());
        }


        // GET: VehicleCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleCard = await _context.VehicleCards
                .SingleOrDefaultAsync(m => m.VehicleCardID == id);
            if (vehicleCard == null)
            {
                return NotFound();
            }

            return View(vehicleCard);
        }

        // GET: VehicleCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleCardID,SeriesAndNumber,ExpirationData,VIN")] VehicleCard vehicleCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleCard);
        }

        // GET: VehicleCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleCard = await _context.VehicleCards.SingleOrDefaultAsync(m => m.VehicleCardID == id);
            if (vehicleCard == null)
            {
                return NotFound();
            }
            return View(vehicleCard);
        }

        // POST: VehicleCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleCardID,SeriesAndNumber,ExpirationData,VIN")] VehicleCard vehicleCard)
        {
            if (id != vehicleCard.VehicleCardID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleCardExists(vehicleCard.VehicleCardID))
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
            return View(vehicleCard);
        }

        // GET: VehicleCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleCard = await _context.VehicleCards
                .SingleOrDefaultAsync(m => m.VehicleCardID == id);
            if (vehicleCard == null)
            {
                return NotFound();
            }

            return View(vehicleCard);
        }

        // POST: VehicleCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleCard = await _context.VehicleCards.SingleOrDefaultAsync(m => m.VehicleCardID == id);
            _context.VehicleCards.Remove(vehicleCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleCardExists(int id)
        {
            return _context.VehicleCards.Any(e => e.VehicleCardID == id);
        }

        public JsonResult ValidateVIN(String vin)
        {
            bool carExisting = _context.Vehicles.Any(m => m.VIN == vin);
            if (carExisting == true)
            {
                return Json(true);
            }
            return Json(false);
        }
        public JsonResult ValidateNumberAndSerial(string seriesAndNumber)
        {
            bool cardExisting = _context.VehicleCards.Any(m => m.SeriesAndNumber == seriesAndNumber);
            if (cardExisting == true)
            {
                return Json(false);
            }
            return Json(true);
        }

    }
}
