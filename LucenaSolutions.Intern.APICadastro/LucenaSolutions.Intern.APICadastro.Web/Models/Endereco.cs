using System.ComponentModel.DataAnnotations;

namespace LucenaSolutions.Intern.APICadastro.Web.Models
{
    public class Endereco
    {
        public int Id { get; private set; }

        [Required]
        public string Logradouro { get; set; }

        [StringLength(8)]
        public string? Numero { get; set; }

        [StringLength(120)]
        public string? Complemento { get; set; }
    }
}