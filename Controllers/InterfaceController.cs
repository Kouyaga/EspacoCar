using Microsoft.AspNetCore.Mvc;
using Projeto.Converter;
using Projeto.Models;
using System.Diagnostics;

namespace Projeto.Controllers
{
    public class InterfaceController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.ListaClientePF = ClientePFController.LerClientePF().ToClientePFViewModel();
            ViewBag.ListaClientePJ = ClientePJController.LerClientePJ();

            return View();
        }
        public IActionResult VerConfiguracoes()
        {
            return View();
        }
        public IActionResult VerPerfil()
        {
            return View();
        }
    }
}
