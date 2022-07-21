using LucenaSolutions.Intern.APICadastro.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace LucenaSolutions.Intern.APICadastro.Web.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; private set; }
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }
    }
}
