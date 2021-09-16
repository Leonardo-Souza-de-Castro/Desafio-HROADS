using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webApi.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            StatusPersonagems = new HashSet<StatusPersonagem>();
        }

        public int IdHabilidade { get; set; }
        public int? IdTipo { get; set; }
        public string NomeHabilidade { get; set; }
        public string DescricaoHabilidade { get; set; }

        public virtual TipoHabilidade IdTipoNavigation { get; set; }
        public virtual ICollection<StatusPersonagem> StatusPersonagems { get; set; }
    }
}
