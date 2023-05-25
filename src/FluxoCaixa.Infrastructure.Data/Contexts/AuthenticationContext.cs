
using FluxoCaixa.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Infrastructure.Data.Contexts
{
    public class AuthenticationContext : DbContext
    {
        public AuthenticationContext(DbContextOptions<CashInContext> options) : base(options)
        {
            
        }

        public DbSet<Launch> CashIn { get; set; }
        public DbSet<object> CashOut { get; set; }
        public DbSet<object> Wallet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
        }


    }
}

