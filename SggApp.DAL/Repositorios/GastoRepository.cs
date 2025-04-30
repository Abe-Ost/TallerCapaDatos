using SggApp.DAL.Entidades;
using SggApp.DAL.Repositorios;

namespace SggApp.DAL.Repositorios
{
    public class GastoRepository : GenericRepository<Gasto>
    {
        public GastoRepository(SggAppContext context) : base(context)
        {
        }

        // No se necesitan métodos específicos adicionales por ahora
    }
}