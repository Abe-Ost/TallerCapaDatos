using System;
using System.Collections.Generic;

namespace SggApp.DAL.Entidades
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public int MonedaId { get; set; }
        public decimal Limite { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Usuario Usuario { get; set; } // Relación con el usuario
        public Categoria Categoria { get; set; } // Relación con la categoría
        public Moneda Moneda { get; set; } // Relación con la moneda

    }
}