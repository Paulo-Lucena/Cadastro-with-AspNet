using LucenaSolutions.Intern.APICadastro.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LucenaSolutions.Intern.APICadastro.Web.Interfaces;

public interface IClienteServices
{ 
    //Get
    public Task<ActionResult<IEnumerable<Cliente>>> Get();

    public Task<ActionResult<Cliente>> GetById(int id);

    public Task<ActionResult<IEnumerable<Cliente>>> GetFull();

    //Post
    public Task<ActionResult> Post(Cliente cliente);

    //Put
    public Task<ActionResult> Put(int id, Cliente cliente);

    //Delete
    public Task<ActionResult> Delete(int id);
}
