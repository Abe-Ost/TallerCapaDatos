using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SggApp.DAL.Repositorios;
using SggApp.DAL.Entidades;


namespace SggApp.DAL.Repositorios
{
    public class UsuarioRepository : GenericRepository<Usuario>
    {
        private readonly SggAppContext _context;  // Renombrado para claridad

        public UsuarioRepository(SggAppContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario> GetByEmailAsync(string email)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email); 
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.Usuarios.AnyAsync(u => u.Email == email); 
        }

        public async Task<IEnumerable<Usuario>> GetAllWithGastosAsync()
        {
            return await _context.Usuarios
                .Include(u => u.Gastos) // Incluir los gastos relacionados
                .ToListAsync(); 
        }
    }
}