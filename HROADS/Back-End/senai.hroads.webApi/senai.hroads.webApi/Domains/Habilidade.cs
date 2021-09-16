using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            StatusPersonagens = new HashSet<StatusPersonagen>();
        }

        public int IdHabilidade { get; set; }
        public int? IdTipo { get; set; }
        public string NomeHabilidade { get; set; }
        public string DescricaoHabilidade { get; set; }

        public virtual TiposHabilidade IdTipoNavigation { get; set; }
        public virtual ICollection<StatusPersonagen> StatusPersonagens { get; set; }
    }
}
