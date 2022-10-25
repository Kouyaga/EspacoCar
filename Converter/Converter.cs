using Projeto.Models;
using Projeto.ViewModel;
using System.Runtime.CompilerServices;

namespace Projeto.Converter
{
    public static class Converter
    {

        private static string AplicarMascaraDeRG(string RG)
        {
            string RGComMascara = string.Empty;

                RGComMascara += RG.PadLeft(9, '0').Substring(0, 2);
                RGComMascara += ".";
                RGComMascara += RG.PadLeft(9, '0').Substring(2, 3);
                RGComMascara += ".";
                RGComMascara += RG.PadLeft(9, '0').Substring(5, 3);
                RGComMascara += "-";
                RGComMascara += RG.PadLeft(9, '0').Substring(8, 1);
            
            return RGComMascara;
        }

        private static string AplicarMascaraDeCPF(string cpf)
        {
            string cpfComMascara = string.Empty;

            cpfComMascara = cpf.PadLeft(11, '0').Substring(0, 3);
            cpfComMascara += ".";
            cpfComMascara += cpf.PadLeft(11, '0').Substring(3, 3);
            cpfComMascara += ".";
            cpfComMascara += cpf.PadLeft(11, '0').Substring(6, 3);
            cpfComMascara += "-";
            cpfComMascara += cpf.PadLeft(11, '0').Substring(9, 2);

            return cpfComMascara;
        }

        public static ClientePF ToClientePF(this ClientePFViewModel dados)
        {

            return new ClientePF()
            {
                CPF = Convert.ToInt64(dados.CPF.Replace("-", "").Replace(".", "")),
                Nome = dados.Nome,
                Sexo = dados.Sexo,
                DataDeNascimento = dados.DataDeNascimento,
                RG = dados.RG.PossuiValor()? dados.RG.Replace("-", "").Replace(".", "") : "",
                Endereco = dados.Endereco,
                Telefones = dados.Telefones.PossuiValor()? Convert.ToInt64(dados.Telefones.Replace("(", "").Replace(" ", "").Replace(")", "").Replace("-", "")) : null,
                Emails = dados.Emails
            };
        }

        public static ClientePFViewModel ToClientePFViewModel(this ClientePF dados)
        {
            return new ClientePFViewModel()
            {
            CPF = AplicarMascaraDeCPF(dados.CPF.ToString()),
            Nome = dados.Nome,
            Sexo = dados.Sexo,
            DataDeNascimento = dados.DataDeNascimento,
            RG = AplicarMascaraDeRG(dados.RG),
            Endereco = dados.Endereco,
            Telefones = dados.Telefones.ToString(),
            Emails = dados.Emails
            };
        }

        public static List<ClientePFViewModel> ToClientePFViewModel(this List<ClientePF> dados)
        {
            var retorno = new List<ClientePFViewModel>();

            foreach (var cliente in dados)
                retorno.Add(cliente.ToClientePFViewModel());

            return retorno;
        }


    }
}
