using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class InstituicaoEvento
    {
        public int IdInstituicaoEvento { get; set; }
        public Nullable<int> IdInstituicao { get; set; }
        public Nullable<int> IdEvento { get; set; }
        public virtual Evento Evento { get; set; }
        public virtual Instituicao Instituicao { get; set; }
    }
}
