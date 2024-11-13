using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finances.Api.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(30)]
        public string Profissao {  get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salario {  get; set; }

        public Collection<Receita> Receitas { get; set; } = new Collection<Receita>();
        public Collection<Despesa> Despesas { get; set; } = new Collection<Despesa>();
    }
}
