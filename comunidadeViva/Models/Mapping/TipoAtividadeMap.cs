using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class TipoAtividadeMap : EntityTypeConfiguration<TipoAtividade>
    {
        public TipoAtividadeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTipoAtividade);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("TipoAtividade");
            this.Property(t => t.IdTipoAtividade).HasColumnName("IdTipoAtividade");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
        }
    }
}
