using FluxoCaixa.Domain.Dtos.Errors;

namespace FluxoCaixa.Domain.Dtos.Generic
{
    public class Result<T>
    {
        public T? Content { get; set; }
        public Error? Error { get; set; }
        public bool IsSuccsess => Error == null;
        public DateTime ResponseTime { get; set; } = DateTime.Now;

    }
}
