using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public EventoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEvento);

            // Properties
            this.Property(t => t.Titulo)
                .HasMaxLength(100);

            this.Property(t => t.Descricao)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("Evento");
            this.Property(t => t.IdEvento).HasColumnName("IdEvento");
            this.Property(t => t.Titulo).HasColumnName("Titulo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DataEvento).HasColumnName("DataEvento");
        }
    }
}
