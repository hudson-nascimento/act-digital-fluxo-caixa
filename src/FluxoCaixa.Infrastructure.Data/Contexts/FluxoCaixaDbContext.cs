
using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infrastructure.Data.Contexts
{
    public class FluxoCaixaDbContext : DbContext
    {
        public FluxoCaixaDbContext(DbContextOptions<CashInContext> options) 
            : base(options)
        {
            
        }

        public DbSet<object> CashIn { get; set; }
        public DbSet<object> CashOut { get; set; }
        public DbSet<Wallet> Wallet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }


    }
}

