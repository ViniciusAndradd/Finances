using Finances.Api.Entities;

namespace Finances.Api.Repositories
{
    public interface IDespesaRepository
    {
        Task<IEnumerable<Despesa>> GetDespesas(int UsuarioId);
        Task<IEnumerable<Despesa>> GetDespesasByCategory(int UsuarioId,int CategoriaId);
    }
}
