using Finances.Api.Context;
using Finances.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Finances.Api.Repositories
{
    public class DespesaRepository : IDespesaRepository
    {
        private readonly AppDbContext _context;

        public DespesaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Despesa>> GetDespesas(int UsuarioId)
        {
            var despesas = await _context.Despesas
                .Where(r => r.UsuarioId == UsuarioId)
                .ToListAsync();

            return despesas;
        }
        

        public async Task<IEnumerable<Despesa>> GetDespesasByCategory(int UsuarioId, int CategoriaId)
        {
            var despesas = await _context.Despesas
                .Where(r => r.UsuarioId == UsuarioId && r.CategoriaId == CategoriaId)
                .ToListAsync();

            return despesas;
        }
    }
}
