using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Context;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;
using ProjetoEvent_.Utils;

namespace ProjetoEvent_.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventPlus_Context _context;

        public UsuarioRepository(EventPlus_Context context)
        {
            _context = context;
        }

        public Usuario BuscarPorEmailESenha(string Email, string Senha)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuarios.FirstOrDefault(u => u.Email == Email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }

                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuario> ListarPorTipo(Guid idTipoUsuario)
        {
            try
            {
                List<Usuario> usuarioPorTipo = _context.Usuarios
                    .Include(u => u.TipoUsuario)
                    .Where(u => u.IdTipoUsuario == idTipoUsuario)
                    .ToList();

                return usuarioPorTipo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
