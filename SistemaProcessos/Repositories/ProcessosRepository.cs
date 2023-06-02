using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaProcessos.Data;
using SistemaProcessos.Models;
using SistemaProcessos.Repositories.Interfaces;

namespace SistemaProcessos.Repositories
{
    public class ProcessosRepository : IProcessosRepository
    {
        private readonly SistemaProcessosDBContext _dbContext;

        public ProcessosRepository(SistemaProcessosDBContext sistemaProcessosDBContext)
        {
            _dbContext = sistemaProcessosDBContext;
        }

        public async Task<List<ProcessosModel>> BuscarProcessosPorAdvogadoId(int advogadoId)
        {
            List<ProcessosModel> processosPorAdvogado = await _dbContext.Processos
                .Where(p => p.Advogado_id == advogadoId)
                .ToListAsync();

            return processosPorAdvogado;
        }

    }
}
