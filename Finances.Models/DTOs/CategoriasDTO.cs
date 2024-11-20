using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Models.DTOs
{
    public class CategoriasDTO
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Tipo { get; set; }
    }
}
