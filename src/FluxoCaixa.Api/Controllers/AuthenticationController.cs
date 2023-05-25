using FluxoCaixa.Api.Configurations;
using Microsoft.AspNetCore.Mvc;

namespace FluxoCaixa.Api.Controllers
{
    [ApiController]
    [Route(template:"api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly JwtConfig _jwtConfig;

        public AuthenticationController(JwtConfig jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }
    }
}
