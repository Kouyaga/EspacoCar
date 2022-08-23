using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System.Diagnostics;

namespace Projeto.Controllers
{
    public class InterfaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ConsultarClientesVIEW()
        {
            return View();
        }
    }
}
