using SggApp.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SggApp.BLL.Interfaces
{
    public interface IPresupuestoService
    {
        Task<IEnumerable<Presupuesto>> ObtenerTodosAsync(); // Obtiene todos los presupuestos
        Task<Presupuesto> ObtenerPorIdAsync(int id); // Obtiene un presupuesto por su ID
        Task<IEnumerable<Presupuesto>> ObtenerPorUsuarioAsync(int usuarioId); // Obtener presupuestos de un usuario
        Task AgregarAsync(Presupuesto presupuesto); // Agrega un presupuesto
        Task ActualizarAsync(Presupuesto presupuesto);  // Actualiza un presupuesto existente
        Task EliminarAsync(int id); // Elimina un presupuesto
    }
}