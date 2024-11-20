using Finances.Api.Repositories;
using Finances.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Finances.Api.Mappings;

namespace Finances.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController:ControllerBase
    {
        private readonly IDespesaRepository _despesaRepository;

        public DespesasController(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        [HttpGet("{UsuarioId:int}")]
        public async Task<ActionResult<IEnumerable<DespesasDTO>>> GetDespesas(int UsuarioId)
        {
            try
            {
                var despesas = await _despesaRepository.GetDespesas(UsuarioId);
                if (despesas is null)
                {
                    return NotFound("Sem Receitas cadastradas");
                }
                else
                {
                    var despesasDto = despesas.ConverterDespesasParaDto();
                    return Ok(despesasDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados {ex.Message}");
            }
        }

        [HttpGet("{UsuarioId:int}/{CategoriaId:int}")]
        public async Task<ActionResult<IEnumerable<DespesasDTO>>> GetDespesasByCategory(int UsuarioId, int CategoriaId)
        {
            try
            {
                var despesas = await _despesaRepository.GetDespesasByCategory(UsuarioId, CategoriaId);
                if (despesas is null)
                {
                    return NotFound("Sem Receitas cadastradas");
                }
                else
                {
                    var despesasDto = despesas.ConverterDespesasParaDto();
                    return Ok(despesasDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao acessar a base de dados {ex.Message}");
            }
        }
    }
}
