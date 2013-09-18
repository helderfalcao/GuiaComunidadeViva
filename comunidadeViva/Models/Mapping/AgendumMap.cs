using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class AgendumMap : EntityTypeConfiguration<Agendum>
    {
        public AgendumMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAgenda);

            // Properties
            this.Property(t => t.Titulo)
                .HasMaxLength(100);

            this.Property(t => t.Descricao)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("Agenda");
            this.Property(t => t.IdAgenda).HasColumnName("IdAgenda");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Titulo).HasColumnName("Titulo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
