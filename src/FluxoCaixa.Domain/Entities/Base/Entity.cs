using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Domain.Entities.Base
{
    /// <summary>
    /// Classe com propriedades básicas de registro 
    /// </summary>
    public class Entity<T>
    {
        /// <summary>
        /// Código de identificação do registro
        /// </summary>
        [Key]
        public Guid Id { get; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Data de criação do registro
        /// </summary>      
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Usuário responsável pela criação do registro
        /// </summary>
        public string? CreatedBy { get; set; }
        /// <summary>
        /// Data de alteração do registro
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Usuário responsável pela alteração do registro
        /// </summary>
        public string? UpdatedBy { get; set; }
    }
}
