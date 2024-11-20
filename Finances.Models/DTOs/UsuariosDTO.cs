using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Models.DTOs
{
    public class UsuariosDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public decimal Salario { get; set; }
    }
}
