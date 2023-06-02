using SistemaProcessos.Models;

namespace SistemaProcessos.Repositories.Interfaces
{
    public interface IProcessosRepository
    {
        Task<List<ProcessosModel>> BuscarProcessosPorAdvogadoId(int id);
    }
}
