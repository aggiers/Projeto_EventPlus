using ProjetoEvent_.Context;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Repositorios
{
    public class TipoUsuarioRepository : ITipoUsuarioRepositoy
    {

        private readonly EventPlus_Context _context;
        public TipoUsuarioRepository(EventPlus_Context context)
        {
            _context = context;
        }


        // atualizar
        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            try
            {
                TipoUsuario tipoUsuarioBuscado = _context.TipoUsuarios.Find(id)!;
                if (tipoUsuarioBuscado != null)
                {
                    tipoUsuarioBuscado.IdTipoUsuario = tipoUsuario.IdTipoUsuario;
                    tipoUsuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TipoUsuario BuscarPorId(Guid id)
        {
            try
            {
                TipoUsuario tipoUsuarioBuscado = _context.TipoUsuarios.Find(id)!;
                return tipoUsuarioBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }


        // cadastrar
        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            try
            {
                _context.TipoUsuarios.Add(tipoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        // deletar 
        public void Deletar(Guid id)
        {
            try
            {
                TipoUsuario tipoUsuarioBuscado = _context.TipoUsuarios.Find(id)!;

                if (tipoUsuarioBuscado != null)
                {
                    _context.TipoUsuarios.Remove(tipoUsuarioBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoUsuario> Listar()
        {
            return _context.TipoUsuarios.ToList();
        }
    }
}
