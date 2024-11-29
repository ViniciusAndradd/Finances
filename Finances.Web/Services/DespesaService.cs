using Finances.Models.DTOs;
using System.Net.Http.Json;

namespace Finances.Web.Services
{
    public class DespesaService : IDespesaService
    {
        public HttpClient _httpClient;
        public ILogger<DespesaService> _logger;

        public DespesaService(HttpClient httpClient, ILogger<DespesaService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        
        public async Task<IEnumerable<DespesasDTO>> GetDespesas(int UsuarioId)
        {
            try
            {
                var despesas = await _httpClient.GetFromJsonAsync<IEnumerable<DespesasDTO>>($"api/despesas/{UsuarioId}");
                return despesas;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao acessar a api {ex.Message}");
                throw;
            }
        }
    }
}
