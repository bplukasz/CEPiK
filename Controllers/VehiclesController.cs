using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CEPiK;
using CEPiK.Models;

namespace CEPiK.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly CepikContext _context;

        public VehiclesController(CepikContext context)
        {
            _context = context;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var cepikContext = _context.Vehicles.Include(v => v.Car).Include(v => v.Owner).Include(v => v.RegistrationBook).Include(v => v.TechnicalResearch).Include(v => v.VehicleCard);
            return View(await cepikContext.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.Car)
                .Include(v => v.Owner)
                .Include(v => v.RegistrationBook)
                .Include(v => v.TechnicalResearch)
                .Include(v => v.VehicleCard)
                .SingleOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            ViewData["CarID"] = new SelectList(_context.Cars, "CarID", "CarID");
            ViewData["PESEL"] = new SelectList(_context.Owners, "PESEL", "PESEL");
            ViewData["RegistrationBookID"] = new SelectList(_context.RegistrationBooks, "RegistrationBookID", "RegistrationBookID");
            ViewData["TechnicalResearchID"] = new SelectList(_context.TechnicalResearchs, "TechnicalResearchID", "TechnicalResearchID");
            ViewData["VehicleCardID"] = new SelectList(_context.VehicleCards, "VehicleCardID", "VehicleCardID");
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleID,Type,RegistrationNumber,TypeApprovalCertificate,ECTypeApproval,VIN,BodyNumber,ManufactureYear,InitialRegistration,WeatherDependent,RegistrationAuthority,DataOfTheBodyNumber,Destination,EngineSize,EnginePower,GrossVehicleWeightRating,AllowedPackage,AxleNumber,PermissibleAxleLoad,MaximumTowedMassOfTheTrailer,Allocation,FirstRegistrationAbroad,Subgenus,SuspensionType,AverageFuelConsumption,MaximumTotalWeight,DeadweightLoad,Equipment,RadarDevice,AutomobileMaker,Wheelbase,WheelbaseMIN,WheelbaseAVG,WheelbaseMAX,CarID,TechnicalResearchID,PESEL,VehicleCardID,RegistrationBookID")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarID"] = new SelectList(_context.Cars, "CarID", "CarID", vehicle.CarID);
            ViewData["PESEL"] = new SelectList(_context.Owners, "PESEL", "PESEL", vehicle.PESEL);
            ViewData["RegistrationBookID"] = new SelectList(_context.RegistrationBooks, "RegistrationBookID", "RegistrationBookID", vehicle.RegistrationBookID);
            ViewData["TechnicalResearchID"] = new SelectList(_context.TechnicalResearchs, "TechnicalResearchID", "TechnicalResearchID", vehicle.TechnicalResearchID);
            ViewData["VehicleCardID"] = new SelectList(_context.VehicleCards, "VehicleCardID", "VehicleCardID", vehicle.VehicleCardID);
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.SingleOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["CarID"] = new SelectList(_context.Cars, "CarID", "CarID", vehicle.CarID);
            ViewData["PESEL"] = new SelectList(_context.Owners, "PESEL", "PESEL", vehicle.PESEL);
            ViewData["RegistrationBookID"] = new SelectList(_context.RegistrationBooks, "RegistrationBookID", "RegistrationBookID", vehicle.RegistrationBookID);
            ViewData["TechnicalResearchID"] = new SelectList(_context.TechnicalResearchs, "TechnicalResearchID", "TechnicalResearchID", vehicle.TechnicalResearchID);
            ViewData["VehicleCardID"] = new SelectList(_context.VehicleCards, "VehicleCardID", "VehicleCardID", vehicle.VehicleCardID);
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleID,Type,RegistrationNumber,TypeApprovalCertificate,ECTypeApproval,VIN,BodyNumber,ManufactureYear,InitialRegistration,WeatherDependent,RegistrationAuthority,DataOfTheBodyNumber,Destination,EngineSize,EnginePower,GrossVehicleWeightRating,AllowedPackage,AxleNumber,PermissibleAxleLoad,MaximumTowedMassOfTheTrailer,Allocation,FirstRegistrationAbroad,Subgenus,SuspensionType,AverageFuelConsumption,MaximumTotalWeight,DeadweightLoad,Equipment,RadarDevice,AutomobileMaker,Wheelbase,WheelbaseMIN,WheelbaseAVG,WheelbaseMAX,CarID,TechnicalResearchID,PESEL,VehicleCardID,RegistrationBookID")] Vehicle vehicle)
        {
            if (id != vehicle.VehicleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.VehicleID))
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
            ViewData["CarID"] = new SelectList(_context.Cars, "CarID", "CarID", vehicle.CarID);
            ViewData["PESEL"] = new SelectList(_context.Owners, "PESEL", "PESEL", vehicle.PESEL);
            ViewData["RegistrationBookID"] = new SelectList(_context.RegistrationBooks, "RegistrationBookID", "RegistrationBookID", vehicle.RegistrationBookID);
            ViewData["TechnicalResearchID"] = new SelectList(_context.TechnicalResearchs, "TechnicalResearchID", "TechnicalResearchID", vehicle.TechnicalResearchID);
            ViewData["VehicleCardID"] = new SelectList(_context.VehicleCards, "VehicleCardID", "VehicleCardID", vehicle.VehicleCardID);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.Car)
                .Include(v => v.Owner)
                .Include(v => v.RegistrationBook)
                .Include(v => v.TechnicalResearch)
                .Include(v => v.VehicleCard)
                .SingleOrDefaultAsync(m => m.VehicleID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicles.SingleOrDefaultAsync(m => m.VehicleID == id);
            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicles.Any(e => e.VehicleID == id);
        }
    }
}
