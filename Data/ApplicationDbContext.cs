using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}