using LanchoneTOP.Models;

namespace LanchoneTOP.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        Lanche GetLancheById(int lancheId);

    }
}
