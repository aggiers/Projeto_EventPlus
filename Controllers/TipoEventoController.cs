using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoEventoController : ControllerBase
    {
        private readonly ITipoEventoRepository _tipoEventoRepository;
        public TipoEventoController(ITipoEventoRepository tipoEventoRepository)
        {
            _tipoEventoRepository = tipoEventoRepository;
        }


        // cadastrar
        [HttpPost]
        public IActionResult Post(TipoEvento tipoEvento)
        {
            try
            {
                _tipoEventoRepository.Cadastrar(tipoEvento);

                return Created();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
   

        // detelar
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                _tipoEventoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        // listar
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TipoEvento> listaDeEventos = _tipoEventoRepository.Listar();
                return Ok(listaDeEventos);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        // buscar por id
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                TipoEvento tipoEventoBuscado = _tipoEventoRepository.BuscarPorId(id);

                return Ok(tipoEventoBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        // atualizar 
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TipoEvento tipoEvento)
        {
            try
            {
                _tipoEventoRepository.Atualizar(id, tipoEvento);

                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }




    }
}
