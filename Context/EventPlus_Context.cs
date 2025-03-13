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

        public DbSet<ComentariosEventos> ComentarioEventos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<PresencasEventos> PresencasEventos { get; set; }
        public DbSet<TiposEventos> TiposEventos { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-U8LA1O3\\SQLEXPRESS; DataBase = EventPlus; User = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }

    }
}
