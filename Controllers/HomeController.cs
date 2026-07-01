using Microsoft.AspNetCore.Mvc;
using LoginApp.Models;

namespace LoginApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.Username == "admin" && model.Password == "1234")
            {
                TempData["User"] = model.Username;
                return RedirectToAction("Welcome");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View(model);
        }

        public IActionResult Welcome()
        {
            ViewBag.User = TempData["User"];
            return View();
        }
    }
}
