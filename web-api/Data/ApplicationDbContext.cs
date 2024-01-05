using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {           
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
