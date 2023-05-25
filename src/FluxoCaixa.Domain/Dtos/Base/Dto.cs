namespace FluxoCaixa.Domain.Dtos.Base
{
    /// <summary>
    /// Classe representa o Data Transfer Object (DTO)
    /// </summary>
    public class Dto
    {
        /// <summary>
        /// Código <see cref="Guid"/> de identificação do registro
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// <see cref="DateTime"/> de criação do registro.
        /// </summary>      
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Usuário responsável pela criação do registro
        /// </summary>
        public UserDto? CreatedBy { get; set; }
        /// <summary>
        /// <see cref="DateTime"/>  de alteração do registro
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Usuário responsável pela alteração do registro
        /// </summary>
        public UserDto? UpdatedBy { get; set; }
    }

}