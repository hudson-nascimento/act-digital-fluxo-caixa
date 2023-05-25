using FluxoCaixa.Domain.Entities.Base;

namespace FluxoCaixa.Domain.Entities
{
    /// <summary>
    /// Movimentação de lançamento do débito ou crédito.
    /// </summary>
    public class Launch : Entity<Launch>
    {
        public double Price { get; set; }
        public string? Description { get; set; }
    }

}
