using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System.Diagnostics;
using System.IO;

namespace Projeto.Controllers
{
    public class ClienteController : Controller
    {
        [HttpPost]
        public IActionResult AdicionarCliente(ClientePF dados)
        {
            StreamWriter SW = new StreamWriter(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\Cliente.txt", true);
            SW.WriteLine(dados.Nome + " " + dados.CPF + " " + dados.Sexo + " " + dados.DataDeNascimento + " " + dados.RG + " " + dados.Endereco + " " + dados.Telefones + " " + dados.Emails);
            SW.Close();

            return RedirectToAction("VerClientes", "Interface");
        }
    }
}
