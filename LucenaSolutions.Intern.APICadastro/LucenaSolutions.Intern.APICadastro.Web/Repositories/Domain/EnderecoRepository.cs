using LucenaSolutions.Intern.APICadastro.Web.Data;
using LucenaSolutions.Intern.APICadastro.Web.Models;
using LucenaSolutions.Intern.APICadastro.Web.Repositories.Interfaces;

namespace LucenaSolutions.Intern.APICadastro.Web.Repositories.Domain
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDBContext context) : base(context)
        {

        }
    }
}
