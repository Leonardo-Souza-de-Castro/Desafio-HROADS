using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Class
    {
        public Class()
        {
            Personagens = new HashSet<Personagen>();
            StatusPersonagens = new HashSet<StatusPersonagen>();
        }

        public int IdClasse { get; set; }
        public string NomeClasse { get; set; }
        public string DescricaoClasse { get; set; }
        public byte Vida { get; set; }
        public byte Mana { get; set; }

        public virtual ICollection<Personagen> Personagens { get; set; }
        public virtual ICollection<StatusPersonagen> StatusPersonagens { get; set; }
    }
}
