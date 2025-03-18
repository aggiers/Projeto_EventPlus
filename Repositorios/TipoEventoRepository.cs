using ProjetoEvent_.Context;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;

namespace ProjetoEvent_.Repositorios
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly EventPlus_Context _context;
        public TipoEventoRepository(EventPlus_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {
            try
            {
                TipoEvento tipoEventoBuscado = _context.TipoEventos.Find(id)!;

                if (tipoEventoBuscado != null)
                {
                    tipoEventoBuscado.IdTipoEvento = tipoEvento.IdTipoEvento;
                    tipoEventoBuscado.TituloTipoEvento = tipoEvento.TituloTipoEvento;

                    _context.TipoEventos.Update(tipoEventoBuscado);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TipoEvento BuscarPorId(Guid id)
        {
            TipoEvento tipoEventoBuscado = _context.TipoEventos.Find(id)!;
            return tipoEventoBuscado;
        }

        public void Cadastrar(TipoEvento tipoEvento)
        {
            try
            {
                _context.TipoEventos.Add(tipoEvento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TipoEvento tipoEvento = _context.TipoEventos.Find(id)!;

                if (tipoEvento != null)
                {
                    _context.TipoEventos.Remove(tipoEvento);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoEvento> Listar()
        {
            return _context.TipoEventos.ToList();
        }
    }
}
