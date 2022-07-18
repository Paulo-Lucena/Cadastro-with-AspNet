using LucenaSolutions.Intern.APICadastro.Web.Data;
using LucenaSolutions.Intern.APICadastro.Web.Interfaces;
using LucenaSolutions.Intern.APICadastro.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LucenaSolutions.Intern.APICadastro.Web.Repositories
{
    public class ClienteRepository : ControllerBase, IClienteRepository
    {

        private readonly AppDBContext _appDBContext;
        private readonly IUnitOfWork _uow;

        public ClienteRepository(AppDBContext appDBContext, IUnitOfWork uow)
        {
            _appDBContext = appDBContext;
            _uow = uow;
        }

        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            var cliente = _appDBContext.Cliente.AsNoTracking().ToArrayAsync();

            if (cliente is null)
            {
                return NotFound();
            }

            return await cliente;
        }

        public async Task<ActionResult<Cliente>> GetById(int id)
        {
            var cliente = _appDBContext.Cliente?.FirstOrDefaultAsync(c => c.Id == id);

            if (cliente is null)
            {
                return NotFound("Cliente não encontrado!");
            }


            return await cliente;
        }

        public async Task<ActionResult<IEnumerable<Cliente>>> GetFull()
        {
            return await _appDBContext.Cliente.Include(c => c.Endereco).ToArrayAsync();
        }

        public async Task<ActionResult> Post(Cliente cliente)
        {
            if (cliente is null)
            {
                return BadRequest();
            }

            _appDBContext.Cliente.Add(cliente);
            await _uow.CommitAsync();

            return Ok();
        }

        public async Task<ActionResult> Put(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _appDBContext.Entry(cliente).State = EntityState.Modified;
            await _uow.CommitAsync();

            return Ok();
        }

        public async Task<ActionResult> Delete(int id)
        {
            var cliente = await _appDBContext.Cliente.FirstOrDefaultAsync(c => c.Id == id);

            if (cliente is null)
            {
                return NotFound();
            }

            _appDBContext.Cliente.Remove(cliente);
            await _uow.CommitAsync();
            return Ok();
        }
    }
}
