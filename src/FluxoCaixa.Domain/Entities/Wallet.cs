using FluxoCaixa.Domain.Entities.Base;

namespace FluxoCaixa.Domain.Entities
{
    /// <summary>
    /// Carteira de saldo.
    /// </summary>
    public class Wallet : Entity<Wallet>
    {
        /// <summary>
        /// Saldo em valores monetários.
        /// </summary>
        public double AccountBalance { get; set; }
    }
}
