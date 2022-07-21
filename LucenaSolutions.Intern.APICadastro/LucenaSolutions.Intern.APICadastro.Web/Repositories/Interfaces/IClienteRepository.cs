using LucenaSolutions.Intern.APICadastro.Web.Models;

namespace LucenaSolutions.Intern.APICadastro.Web.Repositories.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> GetClienteAsync();
    }
}
