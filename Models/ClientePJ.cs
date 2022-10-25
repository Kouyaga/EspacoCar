using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class ClientePJ
    {
        [Key]
        public long CNPJ { get; set; }

        [Required]
        public string RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? Endereco { get; set; }
        public Int64? Telefones { get; set; }
        public string? Emails { get; set; }
    }
}
