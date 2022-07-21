using LucenaSolutions.Intern.APICadastro.Web.Data;
using LucenaSolutions.Intern.APICadastro.Web.Models;
using LucenaSolutions.Intern.APICadastro.Web.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LucenaSolutions.Intern.APICadastro.Web.Repositories.Domain
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDBContext contexto) : base(contexto)
        {

        }

        public async Task<IEnumerable<Cliente>> GetClienteAsync()
        {
            return await Get().Include(c => c.Endereco).ToListAsync();
        }
    }
}


