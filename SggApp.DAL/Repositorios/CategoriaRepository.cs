using SggApp.DAL.Entidades;
using SggApp.DAL.Repositorios;

namespace SggApp.DAL.Repositorios
{
    public class CategoriaRepository : GenericRepository<Categoria>
    {
        public CategoriaRepository(SggAppContext context) : base(context)
        {
        }

        // Puedes agregar métodos específicos si es necesario, por ejemplo,
        // para buscar una categoría por nombre.
    }
}