using Microsoft.AspNetCore.Mvc;
using Projeto.ViewModel;
using Projeto.Converter;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class ClientePFController : ClienteController
    {
        [HttpPost]
        public IActionResult AdicionarNovoClientePF(ClientePFViewModel clientePFViewModel)
        {
            var clientePF = clientePFViewModel.ToClientePF();

            StreamWriter sw = new StreamWriter(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\ClientePF.txt", true);

            sw.Write(clientePF.CPF + ";");

            sw.Write(clientePF.Nome + ";");

            sw.Write(clientePF.Sexo + ";");

            sw.Write(Convert.ToDateTime(clientePF.DataDeNascimento).ToString("dd/MM/yyyy") + ";");

            sw.Write(clientePF.RG + ";");

            sw.Write(clientePF.Endereco + ";");

            sw.Write(clientePF.Telefones + ";");

            sw.WriteLine(clientePF.Emails);

            sw.Close();

            return RedirectToAction("AdicionarCliente", "Cliente");
        }

        public static List<ClientePF> LerClientePF()
        {
            List<ClientePF> clientesPF = new List<ClientePF>();

            StreamReader sr = new StreamReader(@"C:\Users\leonardo.mathias\Desktop\Leonardo\C#\EspacoCar-main\Data\ClientePF.txt");

            string? linha;

            while ((linha = sr.ReadLine()) != null)
            {
                #region Leitura do Arquivo

                ClientePF clientePF = new ClientePF();

                //string linha = sr.ReadLine();
                string[] campos = linha.Split(";");

                clientePF.CPF = Convert.ToInt64(campos[0]);
                clientePF.Nome = campos[1];
                clientePF.Sexo = campos[2];
                clientePF.DataDeNascimento = Convert.ToDateTime(campos[3]);
                clientePF.RG = campos[4];
                clientePF.Endereco = campos[5];
                clientePF.Telefones = campos[6].PossuiValor() ? Convert.ToInt64(campos[6]) : null;
                clientePF.Emails = campos[7];

                clientesPF.Add(clientePF);

                #endregion
            }

            sr.Close();

            return clientesPF;
        }

        public IActionResult ExibirDadosClientePF(string CPF)
        {
            var ListaPf = LerClientePF();
            var cliente = ListaPf.FirstOrDefault(x => x.CPF == Convert.ToInt64(CPF.Replace("-", "").Replace(".", "")));
            return View(cliente);
        }

    }
}
