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

        public async Task<IEnumerable<Receita>> GetReceitas(int UsuarioId)
        {
            var receitas = await _context.Receitas
                .Where(r => r.UsuarioId == UsuarioId)
                .ToListAsync();

            return receitas;
        }

        public async Task<IEnumerable<Receita>> GetReceitasByCategory(int UsuarioId, int CategoriaId)
        {
            var receitas = await _context.Receitas
                .Where(r => r.UsuarioId == UsuarioId && r.CategoriaId == CategoriaId)
                .ToListAsync();

            return receitas;
        }
    }
}
