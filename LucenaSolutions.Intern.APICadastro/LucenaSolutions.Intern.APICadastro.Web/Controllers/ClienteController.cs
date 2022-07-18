using LucenaSolutions.Intern.APICadastro.Web.Interfaces;
using LucenaSolutions.Intern.APICadastro.Web.Models;
using LucenaSolutions.Intern.APICadastro.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LucenaSolutions.Intern.APICadastro.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase, IServices<Cliente>
    {
        private readonly IServices<Cliente> _clienteServices;

        public ClienteController(IServices<Cliente> clienteServices)
        {
            _clienteServices = clienteServices;
        }

        //GET
        [HttpGet]
        public Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            return _clienteServices.Get();
        }

        //api/cliente/1
        [HttpGet("{id:int}")]
        public Task<ActionResult<Cliente>> GetById(int id) => _clienteServices.GetById(id);

        //api/clientefull
/*        [HttpGet("Clientefull")]
        public Task<ActionResult<IEnumerable<Cliente>>> GetFull() => _clienteServices.GetFull();*/

        //POST
        [HttpPost]
        public Task<ActionResult> Post(Cliente cliente) => _clienteServices.Post(cliente);

        //PUT
        [HttpPut("{id:int}")]
        public Task<ActionResult> Put(int id, Cliente cliente) => _clienteServices.Put(id, cliente);

        //DELETE
        [HttpDelete("{id:int}")]
        public Task<ActionResult> Delete(int id) => _clienteServices.Delete(id);

    }
}
