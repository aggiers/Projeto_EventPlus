using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastrar (Evento novoEvento);

        List<Evento> Listar();

        void Atualizar (Guid id, Evento Evento);

        void Deletar (Guid id);

        Evento BuscarPorId (Guid id);

        List<Evento> ProximosEventos();

        List<Evento> ListarPorId (Guid idTipoUsuario, Guid idTipoEvento);
    }
}
