using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CEPiK.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace CEPiK.Controllers
{
    public class HomeController : Controller
    {
        private readonly CepikContext _context;

        public HomeController(CepikContext contex)
        {
            _context = contex;
        }
        public IActionResult Index()
        {
            return View(_context.User.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(user);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user.Name + " został zarejestrowany";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var account = _context.User.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
            if(account != null)
            {
                HttpContext.Session.SetString("ID", account.ID.ToString());
                HttpContext.Session.SetString("Name", account.Name);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "Nazwa użytkownika lub hasło jest błędne");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            if(HttpContext.Session.GetString("ID") != null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Name");
                return View();
            }
            else
            {
                return RedirectToAction("Welcome");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public JsonResult ValidateUserName(string UserName)
        {
            bool userExisting = _context.User.Any(m => m.UserName == UserName);
            if (userExisting == true)
            {
                return Json(false);
            }
            return Json(true);
        }

    }
}
