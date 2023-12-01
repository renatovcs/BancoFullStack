using Microsoft.EntityFrameworkCore;

namespace BancoAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            
        }
    }
}