using Finances.Api.Entities;
using Finances.Api.Context;
using Microsoft.EntityFrameworkCore;

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
            var receitas = await _context.Receitas
                .Where(r => r.IdUsuario ==  IdUsuario)
                .ToListAsync();

            return receitas;
        }

        public async Task<IEnumerable<Receita>> GetReceitasByCategory(int IdCategoria,int IdUsuario)
        {
            var receitas = await _context.Receitas
                .Include(r => r.IdCategoria == IdCategoria && r.IdUsuario == IdUsuario)
                .ToListAsync();

            return receitas;
        }
    }
}
