using SggApp.DAL.Entidades;
using SggApp.DAL.Repositorios;

namespace SggApp.DAL.Repositorios
{
    public class PresupuestoRepository : GenericRepository<Presupuesto>
    {
        public PresupuestoRepository(SggAppContext context) : base(context)
        {
        }

        // Puedes agregar métodos específicos si es necesario
        //  por ejemplo, para buscar presupuestos por rango de fechas
    }
}
