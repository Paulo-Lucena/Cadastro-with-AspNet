using AutoMapper;
using LucenaSolutions.Intern.APICadastro.Web.DTOs;
using LucenaSolutions.Intern.APICadastro.Web.Models;
using LucenaSolutions.Intern.APICadastro.Web.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LucenaSolutions.Intern.APICadastro.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;

        public ClienteController(IUnitOfWork context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDTO>>> Get()
        {
            var clientes = await _context.ClienteRepository.GetClienteAsync();
            var clienteDTO = _mapper.Map<List<ClienteDTO>>(clientes);

            return clienteDTO;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ClienteDTO>> GetById(int id)
        {
            var cliente = await _context.ClienteRepository.GetByIdAsync(p => p.Id == id);

            if (cliente is null)
            {
                return NotFound();
            }

            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClienteDTO clientedto)
        {
            var cliente = _mapper.Map<Cliente>(clientedto);

            _context.ClienteRepository.Add(cliente);
            await _context.CommitAsync();

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> put(int id, [FromBody] ClienteDTO clientedto)
        {
            if (id != clientedto.Id)
            {
                return BadRequest();
            }

            var cliente = _mapper.Map<Cliente>(clientedto);

            _context.ClienteRepository.Update(cliente);
            await _context.CommitAsync();

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ClienteDTO>> Delete(int id)
        {
            var cliente = await _context.ClienteRepository.GetByIdAsync(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            _context.ClienteRepository.Delete(cliente);
            await _context.CommitAsync();

            var ClienteDTO = _mapper.Map<ClienteDTO>(cliente);

            return Ok();
        }

    }
}
