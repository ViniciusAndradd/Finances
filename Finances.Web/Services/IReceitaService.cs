using Finances.Models.DTOs;

namespace Finances.Web.Services
{
    public interface IReceitaService
    {
        Task<IEnumerable<ReceitasDTO>> GetReceitas(int UsuarioId);
    }
}
