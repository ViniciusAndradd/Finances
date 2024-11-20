using Finances.Models.DTOs;
using Finances.Api.Entities;

namespace Finances.Api.Mappings
{
    public static class MappingDTOs
    {
        public static IEnumerable<ReceitasDTO> ConverterReceitasParaDto(this IEnumerable<Receita> receitas) 
        {
            return (from receita in receitas
                    select new ReceitasDTO
                    {
                        Id = receita.Id,
                        Descricao = receita.Descricao,
                        CategoriaId = receita.CategoriaId,
                        Data = receita.Data,
                        Valor = receita.Valor,
                        UsuarioId = receita.UsuarioId
                    }).ToList();
        }

        public static IEnumerable<DespesasDTO> ConverterDespesasParaDto(this IEnumerable<Despesa> despesas)
        {
            return (from despesa in despesas
                    select new DespesasDTO
                    {
                        Id = despesa.Id,
                        Descricao = despesa.Descricao,
                        CategoriaId = despesa.CategoriaId,
                        Data = despesa.Data,
                        Valor = despesa.Valor,
                        UsuarioId = despesa.UsuarioId
                    }).ToList();
        }
    }
}
