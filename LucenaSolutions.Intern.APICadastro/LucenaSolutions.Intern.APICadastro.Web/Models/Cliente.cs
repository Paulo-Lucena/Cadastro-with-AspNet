using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LucenaSolutions.Intern.APICadastro.Web.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        //[JsonIgnore]
        public Endereco Endereco { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;


    }

    //TODO: Verificar o JsonIgnore de Endereço
}
