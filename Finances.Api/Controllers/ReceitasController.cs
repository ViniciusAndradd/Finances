using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Finances.Api.Mappings;
using Finances.Models.DTOs;
using Finances.Api.Repositories;

namespace Finances.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly IReceitaRepository _receitaRepository;

        public ReceitasController(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        [HttpGet("{IdUsuario:int}")]
        public async Task<ActionResult<IEnumerable<ReceitaDTO>>> GetReceitas(int IdUsuario)
        {
            try
            {
                var receitas = await _receitaRepository.GetReceitas(IdUsuario);
                if (receitas is null)
                {
                    return NotFound("Sem Receitas cadastradas");
                }
                else
                {
                    var receitasDto = receitas.ConverterReceitasParaDto();
                    return Ok(receitasDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados {ex.Message}");
            }
        }
    }
}
