using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Domains;

namespace ProjetoEvent_.Context
{
    public class EventPlus_Context : DbContext
    {
        public EventPlus_Context()
        {
        }

        public EventPlus_Context(DbContextOptions<EventPlus_Context> options) : base(options)
        {
        }

        public DbSet<ComentarioEvento> ComentarioEventos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<Presenca> Presencas { get; set; }
        public DbSet<TipoEvento> TipoEventos { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-U8LA1O3\\SQLEXPRESS; DataBase = EventPlus; User = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }

    }
}
