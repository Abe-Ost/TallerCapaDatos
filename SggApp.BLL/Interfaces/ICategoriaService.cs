using SggApp.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SggApp.BLL.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> ObtenerTodosAsync(); // Obtiene todos las categorías
        Task<Categoria> ObtenerPorIdAsync(int id);  // Obtiene una categoría por su ID
        Task<IEnumerable<Categoria>> ObtenerPorUsuarioAsync(int usuarioId); // Obtener categorias de un usuario
        Task AgregarAsync(Categoria categoria); // Agrega una categoría
        Task ActualizarAsync(Categoria categoria);  // Actualiza una categoría existente
        Task EliminarAsync(int id); // Elimina una categoría
    }
}