using Microsoft.EntityFrameworkCore;
using ProdutosCRUD.Models;

namespace ProdutosCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}