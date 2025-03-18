using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        Usuario BuscarPorId(Guid id);
        Usuario BuscarPorEmailESenha(string Email, string Senha);

    }
}
