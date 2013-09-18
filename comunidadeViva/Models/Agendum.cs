using System;
using System.Collections.Generic;

namespace comunidadeViva.Models
{
    public partial class Agendum
    {
        public int IdAgenda { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
