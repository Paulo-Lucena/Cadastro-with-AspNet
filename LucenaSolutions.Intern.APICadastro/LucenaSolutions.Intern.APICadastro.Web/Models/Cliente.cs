using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LucenaSolutions.Intern.APICadastro.Web.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public Endereco Endereco { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;



    }
}
