using Finances.Models.DTOs;

namespace Finances.Web.Services
{
    public interface IDespesaService
    {
        Task<IEnumerable<DespesasDTO>> GetDespesas(int UsuarioId);
    }
}
