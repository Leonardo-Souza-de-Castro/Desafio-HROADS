using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Personagen
    {
        public int IdPersonagem { get; set; }
        public int? IdClasse { get; set; }
        public string NomePersonagem { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
    }
}
