using SggApp.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SggApp.BLL.Interfaces
{
    public interface IGastoService
    {
        Task<IEnumerable<Gasto>> ObtenerTodosAsync(); // Obtiene todos los gastos
        Task<Gasto> ObtenerPorIdAsync(int id); // Obtiene un gasto por suID
        Task<IEnumerable<Gasto>> ObtenerPorUsuarioAsync(int usuarioId); // Obtiene gastos de un usuario
        Task AgregarAsync(Gasto gasto); // Agrega un gasto
        Task ActualizarAsync(Gasto gasto); // Actualiza un gasto existente
        Task EliminarAsync(int id); // Elimina un gasto
    }
}