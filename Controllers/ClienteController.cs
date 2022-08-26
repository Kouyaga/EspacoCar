using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System.Diagnostics;
using System.IO;

namespace Projeto.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult AdicionarCliente(ClientePF dados)
        {
            return Json(new {ok = true});
        }
    }
}
