using Microsoft.AspNetCore.Mvc;

namespace LucenaSolutions.Intern.APICadastro.Web.Services
{
    public interface IServices<T>
    {
        //Get
        public Task<ActionResult<IEnumerable<T>>> Get();

        public Task<ActionResult<T>> GetById(int id);

        //Post
        public Task<ActionResult> Post(T t);

        //Put
        public Task<ActionResult> Put(int id, T t);

        //Delete
        public Task<ActionResult> Delete(int id);
    }
}
