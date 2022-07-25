using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System.Diagnostics;

namespace Projeto.Controllers
{
    public class AuthController : Controller
    { 
        public IActionResult Auth()
        {
            return View();
        }
    }
}