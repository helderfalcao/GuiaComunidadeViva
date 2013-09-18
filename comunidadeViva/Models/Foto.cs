using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class Foto
    {
        public int IdFoto { get; set; }
        public byte[] Imagem { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> IdEvento { get; set; }
        public virtual Evento Evento { get; set; }
    }
}
