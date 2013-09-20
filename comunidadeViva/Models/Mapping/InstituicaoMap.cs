using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace comunidadeViva.Models.Mapping
{
    public class InstituicaoMap : EntityTypeConfiguration<Instituicao>
    {
        public InstituicaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdInstituicao);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(50);

            this.Property(t => t.RazaoSocial)
                .HasMaxLength(100);

            this.Property(t => t.Descricao)
                .HasMaxLength(5000);

            this.Property(t => t.NomeFantasia)
                .HasMaxLength(100);

            this.Property(t => t.CNPJ)
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("Instituicao");
            this.Property(t => t.IdInstituicao).HasColumnName("IdInstituicao");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.FotoCapa).HasColumnName("FotoCapa");
            this.Property(t => t.NomeFantasia).HasColumnName("NomeFantasia");
            this.Property(t => t.CNPJ).HasColumnName("CNPJ");
        }
    }
}
