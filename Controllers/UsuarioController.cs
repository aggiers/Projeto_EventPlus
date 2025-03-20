using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        // cadastrar 
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(usuario);

                return StatusCode(201, usuario);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }



        [HttpGet("{id}")]

        public IActionResult GetByID(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

                if (usuarioBuscado != null)
                {
                    return Ok(usuarioBuscado);
                }

                return null!;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet("tipoUsuario/{idTipoUsuario}")]
        public IActionResult ListarPorTipo(Guid idTipoUsuario)
        {
            List<Usuario> usuario = _usuarioRepository.ListarPorTipo(idTipoUsuario);
            Console.WriteLine(usuario);

            if (usuario == null )
            {
                return NotFound("Nenhum usuario encontrado para esse tipo de usuario.");
            }

            return Ok(usuario);
        }











    }
}
