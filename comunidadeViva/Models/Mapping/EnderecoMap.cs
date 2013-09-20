using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdEndereco);

            // Properties
            this.Property(t => t.Logradouro)
                .HasMaxLength(50);

            this.Property(t => t.Cep)
                .HasMaxLength(8);

            this.Property(t => t.Cidade)
                .HasMaxLength(50);

            this.Property(t => t.Complemento)
                .HasMaxLength(20);

            this.Property(t => t.Numero)
                .HasMaxLength(15);

            this.Property(t => t.PontoReferencia)
                .HasMaxLength(100);

            this.Property(t => t.LinkMapa)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Endereco");
            this.Property(t => t.IdEndereco).HasColumnName("IdEndereco");
            this.Property(t => t.Logradouro).HasColumnName("Logradouro");
            this.Property(t => t.Cep).HasColumnName("Cep");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.Complemento).HasColumnName("Complemento");
            this.Property(t => t.Numero).HasColumnName("Numero");
            this.Property(t => t.PontoReferencia).HasColumnName("PontoReferencia");
            this.Property(t => t.LinkMapa).HasColumnName("LinkMapa");
            this.Property(t => t.IdInstituicao).HasColumnName("IdInstituicao");

            // Relationships
            this.HasOptional(t => t.Instituicao)
                .WithMany(t => t.Enderecoes)
                .HasForeignKey(d => d.IdInstituicao);

        }
    }
}
