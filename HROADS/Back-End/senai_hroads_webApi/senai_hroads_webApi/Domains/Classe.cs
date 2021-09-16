using System;
using System.Collections.Generic;

#nullable disable

namespace senai_hroads_webApi.Domains
{
    public partial class Classe
    {
        public Classe()
        {
            Personagens = new HashSet<Personagen>();
            StatusPersonagems = new HashSet<StatusPersonagem>();
        }

        public int IdClasse { get; set; }
        public string NomeClasse { get; set; }
        public string DescricaoClasse { get; set; }
        public byte Vida { get; set; }
        public byte Mana { get; set; }

        public virtual ICollection<Personagen> Personagens { get; set; }
        public virtual ICollection<StatusPersonagem> StatusPersonagems { get; set; }
    }
}
