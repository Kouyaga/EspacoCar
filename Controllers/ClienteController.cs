using Microsoft.AspNetCore.Mvc;
using Projeto.Controllers;
using System.Diagnostics;
using System.IO;

namespace Projeto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult AdicionarCliente()
        {

            return View();
        }
                        
    }
}

