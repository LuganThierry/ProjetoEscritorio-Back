using Microsoft.EntityFrameworkCore;
using SistemaProcessos.Data.Map;
using SistemaProcessos.Models;

namespace SistemaProcessos.Data
{
    public class SistemaProcessosDBContext : DbContext
    {
        public SistemaProcessosDBContext(DbContextOptions<SistemaProcessosDBContext> options)
            : base(options) 
        {

        }

        public DbSet<PessoasModel> Pessoas { get; set; }

        public DbSet<ProcessosModel> Processos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoasMap());
            modelBuilder.ApplyConfiguration(new ProcessosMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
