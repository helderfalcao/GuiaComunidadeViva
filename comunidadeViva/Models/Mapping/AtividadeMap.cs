using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class AtividadeMap : EntityTypeConfiguration<Atividade>
    {
        public AtividadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdAtividade);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Atividade");
            this.Property(t => t.IdAtividade).HasColumnName("IdAtividade");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.IdTipoAtividade).HasColumnName("IdTipoAtividade");
            this.Property(t => t.IdadeMinima).HasColumnName("IdadeMinima");
            this.Property(t => t.IdadeMaxima).HasColumnName("IdadeMaxima");
            this.Property(t => t.IdInstituicao).HasColumnName("IdInstituicao");

            // Relationships
            this.HasOptional(t => t.Instituicao)
                .WithMany(t => t.Atividades)
                .HasForeignKey(d => d.IdInstituicao);
            this.HasOptional(t => t.TipoAtividade)
                .WithMany(t => t.Atividades)
                .HasForeignKey(d => d.IdTipoAtividade);

        }
    }
}
