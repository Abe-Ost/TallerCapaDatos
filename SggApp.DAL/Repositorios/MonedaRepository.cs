using SggApp.DAL.Entidades;
using SggApp.DAL.Repositorios;

namespace SggApp.DAL.Repositorios
{
    public class MonedaRepository : GenericRepository<Moneda>
    {
        public MonedaRepository(SggAppContext context) : base(context)
        {
        }

        // Puedes agregar métodos específicos si es necesario, por ejemplo,
        // para buscar una moneda por su código.
    }
}