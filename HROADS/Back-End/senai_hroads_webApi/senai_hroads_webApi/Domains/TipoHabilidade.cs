using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webApi.Domains
{
    public partial class TipoHabilidade
    {
        public TipoHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipo { get; set; }
        public string TipoHabilidade1 { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
