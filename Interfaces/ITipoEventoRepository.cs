using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface ITipoEventoRepository
    {
        void Cadastrar (TipoEvento tipoEvento);
        List<TipoEvento> Listar();
        void Deletar (Guid id);
        void Atualizar (Guid id, TipoEvento tipoEvento);
        TipoEvento BuscarPorId (Guid id);

    }
}
