using SggApp.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SggApp.BLL.Interfaces
{
    public interface IMonedaService
    {
        Task<IEnumerable<Moneda>> ObtenerTodosAsync(); // Obtiene todas las monedas
        Task<Moneda> ObtenerPorIdAsync(int id); // Obtiene una moneda por su ID
        Task<IEnumerable<Moneda>> ObtenerPorUsuarioAsync(int usuarioId); // Obtener monedas de un usuario
        Task AgregarAsync(Moneda moneda); // Agrega una moneda
        Task ActualizarAsync(Moneda moneda); // Actualiza una moneda existente
        Task EliminarAsync(int id); // Elimina una moneda
    }
}