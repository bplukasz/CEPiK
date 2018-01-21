using CEPiK.Models;
using CEPiK.ViewModels.VehicleControlStations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Controllers
{
    public class VehicleControlStationsController : Controller
    {
        private readonly CepikContext _context;

        public VehicleControlStationsController(CepikContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index(string searchString)
        {
            var stations = from m in _context.VehicleControlStations select m;
            if (stations != null)
            {
                stations = stations.Where(s => s.NIP.ToString().Contains(searchString)).Include(v => v.Address).Include(v => v.Entrepreneur);
            }
            return View(await stations.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleControlStation = await _context.VehicleControlStations
                .Include(v => v.Address)
                .Include(v => v.Diagnosticians)
                .Include(v => v.Services)
                .Include(v => v.Entrepreneur)
                .SingleOrDefaultAsync(m => m.VehicleControlStationID == id);
            var entrepreneurAddress = await _context.Addresses
                .SingleOrDefaultAsync(m => m.AddressID == vehicleControlStation.AddressID);
            vehicleControlStation.Entrepreneur.Address = entrepreneurAddress;
            if (vehicleControlStation == null)
            {
                return NotFound();
            }

            return View(vehicleControlStation);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleControlStation vehicleControlStation)
        {
            if(_context.VehicleControlStations.Where(s => s.Name.Equals(vehicleControlStation.Name)).FirstOrDefault() != null)
            {
                return RedirectToAction(nameof(Index));
            }
            vehicleControlStation.Entrepreneur.Address = vehicleControlStation.Address;
            _context.Add(vehicleControlStation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleControlStation = await _context.VehicleControlStations
                .Include(v => v.Address)
                .Include(v => v.Diagnosticians)
                .Include(v => v.Services)
                .Include(v => v.Entrepreneur)
                .SingleOrDefaultAsync(m => m.VehicleControlStationID == id);
            var entrepreneurAddress = await _context.Addresses
                .SingleOrDefaultAsync(m => m.AddressID == vehicleControlStation.Entrepreneur.AddressID);
            vehicleControlStation.Entrepreneur.Address = entrepreneurAddress;
            if (vehicleControlStation == null)
            {
                return NotFound();
            }
            return View(vehicleControlStation);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleControlStationID,Name,NIP,AddressID")] VehicleControlStation vehicleControlStation)
        {
            if (id != vehicleControlStation.VehicleControlStationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleControlStation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleControlStationExists(vehicleControlStation.VehicleControlStationID))
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
            return View(vehicleControlStation);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleControlStation = await _context.VehicleControlStations
                .Include(v => v.Address)
                .Include(v => v.Entrepreneur)
                .SingleOrDefaultAsync(m => m.VehicleControlStationID == id);
            if (vehicleControlStation == null)
            {
                return NotFound();
            }

            return View(vehicleControlStation);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleControlStation = await _context.VehicleControlStations.SingleOrDefaultAsync(m => m.VehicleControlStationID == id);
            _context.VehicleControlStations.Remove(vehicleControlStation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleControlStationExists(int id)
        {
            return _context.VehicleControlStations.Any(e => e.VehicleControlStationID == id);
        }
    }
}
