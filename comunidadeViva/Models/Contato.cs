using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class Contato
    {
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public string Fixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Nullable<int> IdInstituicao { get; set; }
        public virtual Instituicao Instituicao { get; set; }
    }
}
