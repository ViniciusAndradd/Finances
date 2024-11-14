using Finances.Models.DTOs;

namespace Finances.Api.Mappings
{
    public static class MappingDTOs
    {
        public static IEnumerable<ReceitaDTO> ConverterReceitasParaDto(this IEnumerable<ReceitaDTO> receitas) 
        {
            return (from receita in receitas
                    select new ReceitaDTO
                    {
                        Id = receita.Id,
                        Descricao = receita.Descricao,
                        IdCategoria = receita.IdCategoria,
                        Data = receita.Data,
                        Valor = receita.Valor,
                        IdUsuario = receita.IdUsuario
                    });
        }
    }
}
