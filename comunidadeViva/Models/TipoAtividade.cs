using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class TipoAtividade
    {
        public TipoAtividade()
        {
            this.Atividades = new List<Atividade>();
        }

        public int IdTipoAtividade { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Atividade> Atividades { get; set; }
    }
}
