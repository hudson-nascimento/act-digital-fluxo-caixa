using FluxoCaixa.Domain.Dtos.Base;

namespace FluxoCaixa.Domain.Dtos
{
    /// <summary>
    /// Classe para representar o Relatorio Analitico (Completo).
    /// </summary>
    public class ReportDto : Dto
    {
        public string? Status { get; set; }
    }
}
