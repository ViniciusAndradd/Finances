using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Finances.Api.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        public int Tipo { get; set; }

        public Collection<Receita> Receitas { get; set; } = new Collection<Receita>();
        public Collection<Despesa> Despesas { get; set; } = new Collection<Despesa>();
    }
}
