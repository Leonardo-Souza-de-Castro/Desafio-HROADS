using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webApi.Domains
{
    public partial class StatusPersonagem
    {
        public int IdStatus { get; set; }
        public int? IdHabilidade { get; set; }
        public int? IdClasse { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
