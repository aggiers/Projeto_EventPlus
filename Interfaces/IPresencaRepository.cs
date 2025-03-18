using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Interfaces
{
    public interface IPresencaRepository
    {
        List<Presenca> Listar ();
        Presenca BuscarPorId (Guid id);
        void Atualizar (Guid id, Presenca presenca);
        List<Presenca> ListarMinhasPresencas (Guid id);
        void Inscrever (Guid id);
        void Deletar (Guid id);
    }
}
