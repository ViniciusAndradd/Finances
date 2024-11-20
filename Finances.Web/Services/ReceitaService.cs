using Finances.Models.DTOs;
using System.Net.Http.Json;

namespace Finances.Web.Services
{
    public class ReceitaService : IReceitaService
    {
        public HttpClient _httpClient;
        public ILogger<ReceitaService> _logger;

        public ReceitaService(HttpClient httpClient, ILogger<ReceitaService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<ReceitasDTO>> GetReceitas(int UsuarioId)
        {
            try
            {
                var receitasDto = await _httpClient.GetFromJsonAsync<IEnumerable<ReceitasDTO>>("api/receitas");
                return receitasDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao acessar a api {ex.Message}");
                throw;
            }

        }
    }
}
