using LucenaSolutions.Intern.APICadastro.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace LucenaSolutions.Intern.APICadastro.Web.Interfaces;

public interface IClienteRepository
{
    //Get
    public Task<ActionResult<IEnumerable<Cliente>>> GetFull();

    Task<ActionResult<IEnumerable<Cliente>>> Get();

    public Task<ActionResult<Cliente>> GetById(int id);

    //Post
    public Task<ActionResult> Post(Cliente cliente);

    //Put
    public Task<ActionResult> Put(int id, Cliente cliente);

    //Delete
    public Task<ActionResult> Delete(int id);

}
