using System.ComponentModel;

namespace FluxoCaixa.Domain.Enums
{
    /// <summary>
    /// Tipo de lançameto
    /// </summary>
    public enum LaunchTypeEnum
    {
        [Description("Credito")]
        Credit = 1,
        [Description("Debito")]
        Debt = 2
    }
}
