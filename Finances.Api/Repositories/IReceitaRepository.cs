using Finances.Api.Entities;
using Finances.Models.DTOs;

namespace Finances.Api.Repositories
{
    public interface IReceitaRepository
    {
        Task<IEnumerable<Receita>> GetReceitas(int IdUsuario);
        Task<IEnumerable<Receita>> GetReceitasByCategory(int UsuarioId,int CategoriaId);
    }
}
