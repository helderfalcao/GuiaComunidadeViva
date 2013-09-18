using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class InstituicaoEventoMap : EntityTypeConfiguration<InstituicaoEvento>
    {
        public InstituicaoEventoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdInstituicaoEvento);

            // Properties
            // Table & Column Mappings
            this.ToTable("InstituicaoEvento");
            this.Property(t => t.IdInstituicaoEvento).HasColumnName("IdInstituicaoEvento");
            this.Property(t => t.IdInstituicao).HasColumnName("IdInstituicao");
            this.Property(t => t.IdEvento).HasColumnName("IdEvento");

            // Relationships
            this.HasOptional(t => t.Evento)
                .WithMany(t => t.InstituicaoEventoes)
                .HasForeignKey(d => d.IdEvento);
            this.HasOptional(t => t.Instituicao)
                .WithMany(t => t.InstituicaoEventoes)
                .HasForeignKey(d => d.IdInstituicao);

        }
    }
}
