using System;
using System.Collections.Generic;

namespace SggApp.DAL.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Gasto> Gastos { get; set; } // Una categoria puede tener muchos gastos
        public ICollection<Presupuesto> Presupuestos { get; set; } // Una categoria puede tener muchos presupuestos
    }
}