using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class Evento
    {
        public Evento()
        {
            this.Fotoes = new List<Foto>();
            this.InstituicaoEventoes = new List<InstituicaoEvento>();
        }

        public int IdEvento { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataEvento { get; set; }
        public virtual ICollection<Foto> Fotoes { get; set; }
        public virtual ICollection<InstituicaoEvento> InstituicaoEventoes { get; set; }
    }
}
