using Finances.Api.Entities;

namespace Finances.Api.Repositories
{
    public interface IDespesaRepository
    {
        Task<IEnumerable<Despesa>> GetReceitas();
        Task<Despesa> GetDespesasByCategory(int Id);
    }
}
