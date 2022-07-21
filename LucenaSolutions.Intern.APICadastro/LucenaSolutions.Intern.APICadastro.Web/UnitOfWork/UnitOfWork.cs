using LucenaSolutions.Intern.APICadastro.Web.Data;
using LucenaSolutions.Intern.APICadastro.Web.Repositories.Domain;
using LucenaSolutions.Intern.APICadastro.Web.Repositories.Interfaces;

namespace LucenaSolutions.Intern.APICadastro.Web.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IClienteRepository _clienteRepository;
        private IEnderecoRepository _enderecoRepository;
        private AppDBContext _context;

        public UnitOfWork(AppDBContext appDBContext)
        {
            _context = appDBContext;
        }

        public IClienteRepository ClienteRepository
        {
            get
            {
                return _clienteRepository = _clienteRepository ?? new ClienteRepository(_context);
            }
        }

        public IEnderecoRepository EnderecoRepository
        {
            get
            {
                return _enderecoRepository = _enderecoRepository ?? new EnderecoRepository(_context);
            }
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
