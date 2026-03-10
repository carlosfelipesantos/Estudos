using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class AppDbContext:DbContext 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //construtor da classe AppDbContext, que recebe as opções de configuração do DbContext e as passa para a classe base
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; } //representando a tabela categorias do banco de dados
        public DbSet<Produto> Produtos { get; set; }

    }
}
