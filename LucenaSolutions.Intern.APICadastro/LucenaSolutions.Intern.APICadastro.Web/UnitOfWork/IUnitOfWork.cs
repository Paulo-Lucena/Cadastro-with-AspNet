using LucenaSolutions.Intern.APICadastro.Web.Repositories.Interfaces;

namespace LucenaSolutions.Intern.APICadastro.Web.UnitOfWork
{
    public interface IUnitOfWork
    {
        IClienteRepository ClienteRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        Task CommitAsync();
    }
}
