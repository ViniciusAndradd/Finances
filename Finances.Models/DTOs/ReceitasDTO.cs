using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Models.DTOs
{
    public class ReceitasDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public DateOnly Data { get; set; }
        public decimal Valor { get; set; }
        public int UsuarioId { get; set; }
    }
}
