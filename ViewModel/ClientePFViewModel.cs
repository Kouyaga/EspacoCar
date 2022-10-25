using Projeto.Models;
using System.ComponentModel.DataAnnotations;

namespace Projeto.ViewModel
{
    public class ClientePFViewModel 
        
    {
        [Key]
        public string CPF { get; set; }

        [Required]
        public string Nome { get; set; }
        public string? Sexo { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public string? RG { get; set; }
        public string? Endereco { get; set; }
        public string? Telefones { get; set; }
        public string? Emails { get; set; }

    }
}
