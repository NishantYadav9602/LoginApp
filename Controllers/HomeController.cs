using LoginApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
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

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            ViewBag.User = "admin";

            if (file == null || file.Length == 0)
            {
                ViewBag.Message = "Please select a file.";
                return View("Welcome");
            }

            var uploadFolder = Path.Combine(_environment.WebRootPath, "uploads");

            Directory.CreateDirectory(uploadFolder);

            var filePath = Path.Combine(uploadFolder, file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            ViewBag.Message = "File uploaded successfully!";
            ViewBag.FileName = file.FileName;

            return View("Welcome");
        }
    }
}
