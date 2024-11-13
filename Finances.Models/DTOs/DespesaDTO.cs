﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances.Models.DTOs
{
    public class DespesaDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public DateOnly Data { get; set; }
        public decimal Valor { get; set; }
        public int IdUsuario { get; set; }
    }
}