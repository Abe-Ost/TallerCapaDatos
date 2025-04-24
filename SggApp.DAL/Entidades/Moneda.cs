using System;
using System.Collections.Generic;

namespace SggApp.DAL.Entidades
{
    public class Moneda
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }

        public ICollection<Gasto> Gastos { get; set; } // Una moneda puede estar asociada a muchos gastos
        public ICollection<Presupuesto> Presupuestos { get; set; } // Una moneda puede estar asociada a muchos presupuestos
    }
}