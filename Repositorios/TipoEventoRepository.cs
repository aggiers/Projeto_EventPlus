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
                   tipoEventoBuscado.TituloTipoEvento = tipoEvento.TituloTipoEvento;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        // buscar evento por id
        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
                TipoEvento tipoEventoBuscado = _context.TipoEventos.Find(id)!;

                return tipoEventoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
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
