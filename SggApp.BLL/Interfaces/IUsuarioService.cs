using SggApp.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SggApp.BLL.Servicios;

namespace SggApp.BLL.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ObtenerTodosAsync(); // Obtiene todos los usuarios
        Task<Usuario> ObtenerPorIdAsync(int id);    // Obtiene un usuario por su ID
        Task<IEnumerable<Usuario>> ObtenerPorUsuarioAsync(int usuarioId); // Obtener usuarios de un usuario
        Task AgregarAsync(Usuario usuario); // Agrega un usuario
        Task ActualizarAsync(Usuario usuario);  // Actualiza un usuario existente
        Task EliminarAsync(int id); // Elimina un usuario
    }
}