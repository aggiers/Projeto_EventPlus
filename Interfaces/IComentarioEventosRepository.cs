using ProjetoEvent_.Domains;
using System.Security.Cryptography;

namespace ProjetoEvent_.Interfaces
{
    public interface IComentarioEventosRepository
    {
        //cadastrar
        void Cadastrar(ComentarioEvento comentarioEvento);

        //deletar 
        void Deletar(Guid id);

        //listar 
        List<ComentarioEvento> Listar(Guid id);

        //BuscarPorIdUsuario
        ComentarioEvento BuscarPorIdUsuario(Guid idUsuario, Guid IdEvento);
    }
}
