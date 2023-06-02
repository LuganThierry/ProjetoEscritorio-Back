using Microsoft.EntityFrameworkCore;
using SistemaProcessos.Data;
using SistemaProcessos.Models;
using SistemaProcessos.Repositories.Interfaces;

namespace SistemaProcessos.Repositories
{
    public class PessoasRepository : IPessoasRepository
    {
        private readonly SistemaProcessosDBContext _DbContext;
        public PessoasRepository(SistemaProcessosDBContext sistemaProcessosDBContext)
        {
            _DbContext = sistemaProcessosDBContext;
        }

        public async Task<PessoasModel> BuscarPorId(int id)
        {
            PessoasModel pessoaPorId = await _DbContext.Pessoas.FirstOrDefaultAsync(x => x.Id == id);

            return pessoaPorId;
        }

        public async Task<List<PessoasModel>> BuscarTodasPessoas()
        {
            return await _DbContext.Pessoas.ToListAsync();
        }
    }
}
