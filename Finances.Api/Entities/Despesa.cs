using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finances.Api.Entities
{
    public class Despesa
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public DateOnly Data { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public int UsuarioId { get; set; }
    }
}
