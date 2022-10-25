using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class ClientePF
    {
        [Key]
        public Int64 CPF { get; set; }

        [Required]
        public string Nome { get; set; }
        public string? Sexo { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public string? RG { get; set; }
        public string? Endereco { get; set; }
        public Int64? Telefones { get; set; }
        public string? Emails { get; set; }

    }
}
