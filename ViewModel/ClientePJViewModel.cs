using System.ComponentModel.DataAnnotations;

namespace Projeto.ViewModel
{
    public class ClientePJViewModel
    {

        [Key]
        public string CNPJ { get; set; }

        [Required]
        public string RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? Endereco { get; set; }
        public string? Telefones { get; set; }
        public string? Emails { get; set; }
    }
}
