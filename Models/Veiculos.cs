using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Veiculos
    {
        public string? CPFProprietario { get; set; }

        [Key]
        public string Placa { get; set; }
    }
}
