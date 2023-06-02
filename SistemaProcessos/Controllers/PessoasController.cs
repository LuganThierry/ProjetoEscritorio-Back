using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaProcessos.Models;
using SistemaProcessos.Repositories.Interfaces;

namespace SistemaProcessos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoasRepository _pessoasRepository;
        public PessoasController(IPessoasRepository pessoasRepository)
        {
            _pessoasRepository = pessoasRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<PessoasModel>>> BuscarTodasPessoas()
        {
            List<PessoasModel> pessoas = await _pessoasRepository.BuscarTodasPessoas();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<PessoasModel>>> BuscarPorId(int id)
        {
            PessoasModel pessoas = await _pessoasRepository.BuscarPorId(id);

            if (pessoas == null)
            {
                return StatusCode(404, $"Não foram um advogado com o ID: {id}");
            }

            return Ok(pessoas);
        }
    }
}
