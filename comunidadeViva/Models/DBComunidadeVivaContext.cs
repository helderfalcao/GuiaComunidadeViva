using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using comunidadeViva.Models.Mapping;

namespace comunidadeViva.Models
{
    public partial class DBComunidadeVivaContext : DbContext
    {
        static DBComunidadeVivaContext()
        {
            Database.SetInitializer<DBComunidadeVivaContext>(null);
        }

        public DBComunidadeVivaContext()
            : base("Name=DBComunidadeVivaContext")
        {
        }

        public DbSet<Agendum> Agenda { get; set; }
        public DbSet<Atividade> Atividades { get; set; }
        public DbSet<Contato> Contatoes { get; set; }
        public DbSet<Endereco> Enderecoes { get; set; }
        public DbSet<Evento> Eventoes { get; set; }
        public DbSet<Foto> Fotoes { get; set; }
        public DbSet<Instituicao> Instituicaos { get; set; }
        public DbSet<InstituicaoEvento> InstituicaoEventoes { get; set; }
        public DbSet<TipoAtividade> TipoAtividades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AgendumMap());
            modelBuilder.Configurations.Add(new AtividadeMap());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new EventoMap());
            modelBuilder.Configurations.Add(new FotoMap());
            modelBuilder.Configurations.Add(new InstituicaoMap());
            modelBuilder.Configurations.Add(new InstituicaoEventoMap());
            modelBuilder.Configurations.Add(new TipoAtividadeMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}
