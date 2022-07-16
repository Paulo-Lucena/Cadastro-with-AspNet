using LucenaSolutions.Intern.APICadastro.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LucenaSolutions.Intern.APICadastro.Web.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

       public DbSet<Cliente> Cliente { get; set; }
       public DbSet<Endereco> Endereco { get; set; }
    }
}
