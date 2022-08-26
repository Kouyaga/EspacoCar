using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System.Diagnostics;
using System.IO;

namespace Projeto.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
        public IActionResult Home()

        {
            return View();
        }

        [HttpPost]
        public IActionResult VerificarLogin(string login)
        {
            StreamReader Reader = new StreamReader(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\Login.txt", false);
            string loginAUTH = Reader.ReadLine();
            Reader.Close();

            if (loginAUTH == login)
            {
                return Json(new { ok = true });
            }
            else
            {
                return Json(new { ok = false });
            }
        }
        public IActionResult VerificarSenha(string senha)
        {
            StreamReader Reader = new StreamReader(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\Senha.txt", false);
            string senhaAUTH = Reader.ReadLine();
            Reader.Close();

            if (senhaAUTH == senha)
            {
                return Json(new { ok = true });
            }
            else
            {
                return Json(new { ok = false });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}