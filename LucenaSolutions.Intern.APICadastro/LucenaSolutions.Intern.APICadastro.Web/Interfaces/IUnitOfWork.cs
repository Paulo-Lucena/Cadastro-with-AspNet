using Microsoft.AspNetCore.Mvc;

namespace LucenaSolutions.Intern.APICadastro.Web.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        IActionResult RollBack();
    }
}
