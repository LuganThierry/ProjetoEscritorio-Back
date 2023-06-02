using SistemaProcessos.Models;

namespace SistemaProcessos.Repositories.Interfaces
{
    public interface IPessoasRepository
    {
        Task<PessoasModel> BuscarPorId(int id);

        Task<List<PessoasModel>> BuscarTodasPessoas();

    }
}
