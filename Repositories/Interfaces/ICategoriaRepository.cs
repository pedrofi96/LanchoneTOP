using LanchoneTOP.Models;

namespace LanchoneTOP.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
