
using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infrastructure.Data.Contexts
{
    public class WalletContext : DbContext
    {
        public WalletContext(DbContextOptions<CashInContext> options) : base(options)
        {
            
        }

        public DbSet<object> CashIn { get; set; }
        public DbSet<object> CashOut { get; set; }
        public DbSet<object> Wallet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }


    }
}

