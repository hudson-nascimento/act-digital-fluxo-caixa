using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace FluxoCaixa.Api.Controllers
{
    [Route("Api/[controller]/[action]")]
    public class CashInController : Controller
    {
        #region Properties and variables
        private readonly IFluxoCaixaService _service;

        #endregion

        #region Constructor method
        public CashInController(IFluxoCaixaService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Retorna informações do caixa
        /// </summary>
        /// <returns><see cref="Wallet"/></returns>
        /// <response code="200">Status code 200 (Ok) Retorna os dados registrados</response>
        /// <response code="400">Status code 400 (BadRequest) Retorna erro na requisição</response>
        /// <response code="404">Status code 404 (NotFound) Informação não encontrada</response>
        [HttpGet]
        [ProducesResponseType(typeof(Wallet), 200)]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAll();

            if (result == null)
            {
                return NotFound();
            }

            Log.Information(result);

            return Ok(result);
        }

        /// <summary>
        /// Regidtra os dados de lancamento
        /// </summary>
        /// <returns><see cref="Wallet"/></returns>
        /// <response code="201">Status code 200 (Created) Retorna os itens registrados na base</response>
        /// <response code="400">Status code 400 (BadRequest) Retorna erro na requisição</response>
        [HttpPost]
        [ProducesResponseType(typeof(Wallet), 201)]
        public async Task<IActionResult> Add()
        {
            var result = await _service.Add();

            if (result == null)
            {
                return NotFound();
            }

            Log.Information(result);

            return Ok(result);
        }
        #endregion
    }
}
