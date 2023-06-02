using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaProcessos.Models;
using SistemaProcessos.Repositories.Interfaces;

namespace SistemaProcessos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessosController : ControllerBase
    {
        private readonly IProcessosRepository _processosRepository;

        public ProcessosController(IProcessosRepository processosRepository)
        {
            _processosRepository = processosRepository;
        }

        [HttpGet("advogado/{id}/processos")]
        public async Task<ActionResult<List<ProcessosModel>>> BuscarProcessosPorAdvogadoId(int id)
        {
            List<ProcessosModel> processosModel = await _processosRepository.BuscarProcessosPorAdvogadoId(id);

            if (processosModel.Count == 0)
            {
                return StatusCode(404, $"Não foram um advogado com o ID: {id}");
            }

            return Ok(processosModel);
        }
    }
}
