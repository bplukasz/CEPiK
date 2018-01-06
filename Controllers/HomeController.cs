using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CEPiK.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;

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
        public ActionResult Register(Models.CepikContext user)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(user);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = user.Name + " is successfully registered";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.CepikContext user)
        {
            var account = _context.User.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
            if(account != null)
            {
                HttpContext.Session.SetString("UserID", account.ID.ToString());
                HttpContext.Session.SetString("UserName", account.UserName);
                return RedirectToAction("Witamy !");
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
                ViewBag.UserName = HttpContext.Session.GetString("UserName");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
