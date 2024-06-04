using LanchoneTOP.Context;
using LanchoneTOP.Models;
using LanchoneTOP.Repositories.Interfaces;

namespace LanchoneTOP.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context; 
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
