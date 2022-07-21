namespace LucenaSolutions.Intern.APICadastro.Web.DTOs
{
    public class EnderecoDTO
    {
        public int Id { get; private set; }
        public string Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
    }
}
