using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class ClientePJController : ClienteController
    {
        [HttpPost]
        public IActionResult AdicionarNovoClientePJ(ClientePJ clientePJ)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\ClientePF.txt", true);

            sw.Write(clientePJ.CNPJ.ToString() + ";");
            sw.Write(clientePJ.RazaoSocial + ";");
            sw.Write(clientePJ.NomeFantasia);
            sw.Write(clientePJ.Endereco + ";");
            sw.Write(clientePJ.Telefones.ToString() + ";");
            sw.WriteLine(clientePJ.Emails);

            sw.Close();

            return RedirectToAction("AdicionarCliente", "Cliente");
        }

        public static List<ClientePJ> LerClientePJ()
        {
            List<ClientePJ> clientesPJ = new List<ClientePJ>();

            StreamReader sr = new StreamReader(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\ClientePJ.txt");

            string? linha;

            while ((linha = sr.ReadLine()) != null)
            {
                #region Leitura do Arquivo

                ClientePJ clientePJ = new ClientePJ();

                //string linha = sr.ReadLine();
                string[] campos = linha.Split(";");

                clientePJ.CNPJ = Convert.ToInt64(campos[0]);
                clientePJ.RazaoSocial = campos[1];
                clientePJ.NomeFantasia = campos[2];
                clientePJ.Endereco = campos[3];
                clientePJ.Telefones = Convert.ToInt64(campos[4]);
                clientePJ.Emails = campos[5];

                clientesPJ.Add(clientePJ);

                #endregion
            }

            sr.Close();

            return clientesPJ;
        }

        public IActionResult AlterarClientePJ()
        {

            return View();
        }

    }
}
