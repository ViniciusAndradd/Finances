﻿using Finances.Api.Entities;

namespace Finances.Api.Repositories
{
    public interface IReceitaRepository
    {
        Task<IEnumerable<Receita>> GetReceitas(int IdUsuario);
        Task<Receita> GetReceitasByCategory(int IdCategoria);
    }
}
