using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class FotoMap : EntityTypeConfiguration<Foto>
    {
        public FotoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFoto);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("Foto");
            this.Property(t => t.IdFoto).HasColumnName("IdFoto");
            this.Property(t => t.Imagem).HasColumnName("Imagem");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.IdEvento).HasColumnName("IdEvento");

            // Relationships
            this.HasOptional(t => t.Evento)
                .WithMany(t => t.Fotoes)
                .HasForeignKey(d => d.IdEvento);

        }
    }
}
