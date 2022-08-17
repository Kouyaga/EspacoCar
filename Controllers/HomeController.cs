using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System.Diagnostics;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
             
        public IActionResult Auth()
        {

            return View();
        }

        [HttpPost]
        public IActionResult VerificarLogin(string login)
        {
            string loginAUTH = "admin";

            if (loginAUTH == login)
                return Json(new { ok = true });
            else
                return Json(new { ok = false });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}