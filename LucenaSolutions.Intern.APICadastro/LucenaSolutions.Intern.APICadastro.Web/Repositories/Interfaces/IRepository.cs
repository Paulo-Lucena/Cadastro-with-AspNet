using System.Linq.Expressions;

namespace LucenaSolutions.Intern.APICadastro.Web.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> Get(); //IQueryable permite chamadas assíncronas
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
