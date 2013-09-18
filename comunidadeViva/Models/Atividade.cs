using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class Atividade
    {
        public int IdAtividade { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> IdTipoAtividade { get; set; }
        public Nullable<int> IdadeMinima { get; set; }
        public Nullable<int> IdadeMaxima { get; set; }
        public Nullable<int> IdInstituicao { get; set; }
        public virtual Instituicao Instituicao { get; set; }
        public virtual TipoAtividade TipoAtividade { get; set; }
    }
}
