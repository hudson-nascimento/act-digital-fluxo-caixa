using FluxoCaixa.Domain.Dtos.Base;

namespace FluxoCaixa.Domain.Dtos
{
    public class UserDto : Dto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Country { get; set; }
    }
}
