using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            this.Atividades = new List<Atividade>();
            this.Contatoes = new List<Contato>();
            this.Enderecoes = new List<Endereco>();
            this.InstituicaoEventoes = new List<InstituicaoEvento>();
        }

        public int IdInstituicao { get; set; }
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string Descricao { get; set; }
        public byte[] FotoCapa { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public virtual ICollection<Atividade> Atividades { get; set; }
        public virtual ICollection<Contato> Contatoes { get; set; }
        public virtual ICollection<Endereco> Enderecoes { get; set; }
        public virtual ICollection<InstituicaoEvento> InstituicaoEventoes { get; set; }
    }
}
