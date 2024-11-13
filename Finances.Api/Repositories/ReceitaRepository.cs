using Finances.Api.Entities;
using Finances.Api.Context;

namespace Finances.Api.Repositories
{
    public class ReceitaRepository : IReceitaRepository
    {
        private readonly AppDbContext _context;

        public ReceitaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Receita>> GetReceitas(int IdUsuario)
        {
            
        }

        public Task<Receita> GetReceitasByCategory(int IdCategoria)
        {
            
        }
    }
}
