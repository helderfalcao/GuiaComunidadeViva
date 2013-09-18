using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdContato);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(1000);

            this.Property(t => t.Fixo)
                .HasMaxLength(15);

            this.Property(t => t.Celular)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Contato");
            this.Property(t => t.IdContato).HasColumnName("IdContato");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Fixo).HasColumnName("Fixo");
            this.Property(t => t.Celular).HasColumnName("Celular");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.IdInstituicao).HasColumnName("IdInstituicao");

            // Relationships
            this.HasOptional(t => t.Instituicao)
                .WithMany(t => t.Contatoes)
                .HasForeignKey(d => d.IdInstituicao);

        }
    }
}
