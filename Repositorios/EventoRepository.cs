using ProjetoEvent_.Context;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Repositorios
{
    public class EventoRepository : IEventoRepository
    {

        private readonly EventPlus_Context _context;

        public EventoRepository(EventPlus_Context context)
        {
            _context = context;
        }


        public void Atualizar(Guid id, Evento Evento)
        {

            try
            {

                Evento eventoBuscado = _context.Eventos.Find(id);

                if (eventoBuscado != null)
                {
                    eventoBuscado.NomeEvento = Evento.NomeEvento;
                    eventoBuscado.DataEvento = Evento.DataEvento;
                    eventoBuscado.Descricao = Evento.Descricao;
                    eventoBuscado.IdTipoEvento = Evento.IdTipoEvento;
                    eventoBuscado.IdTipoUsuario = Evento.IdTipoUsuario;

                }

                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Evento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Evento novoEvento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Evento> ListarPorId(Guid idTipoUsuario, Guid idTipoEvento)
        {
            throw new NotImplementedException();
        }

        public List<Evento> ProximosEventos()
        {
            throw new NotImplementedException();
        }
    }
}
