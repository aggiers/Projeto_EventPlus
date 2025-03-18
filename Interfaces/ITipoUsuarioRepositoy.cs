using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface ITipoUsuarioRepositoy
    {
        void Cadastrar(TipoUsuario tipoUsuario);
        void Deletar(Guid id);
        List<TipoUsuario> Listar();
        TipoUsuario BuscarUsuarioPorId(Guid id);
        void Atualizar(Guid id, TipoUsuario tipoUsuario);
    }
}
