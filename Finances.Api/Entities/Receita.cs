using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finances.Api.Entities
{
    public class Receita
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public int IdCategoria {  get; set; }
        public DateOnly Data { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        public int IdUsuario { get; set; }

        public Categoria Categoria { get; set; }
        public Usuario Usuario { get; set; }
    }
}
