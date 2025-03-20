using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;
        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }


        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        List<Evento> listaDeEventos = _eventoRepository.Listar();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //[HttpPost]
        //public IActionResult Post()
        //{

        //}

        //[HttpPut]
        //public IActionResult Put()
        //{

        //}

        //[HttpDelete]
        //public IActionResult DeleteById()
        //{

        //}

        //[HttpGet]
        //public IActionResult GetById(Guid id)
        //{

        //}

        //[HttpGet]
        //public IActionResult GetById(Guid idTipoUsuario, Guid idTipoEvento)
        //{

        //}

    }
}
