using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int id, Classe ClasseAtualizada)
        {
            Classe ClasseBuscada = Buscar(id);

            if (ClasseBuscada.DescricaoClasse != null)
            {
                ClasseBuscada.DescricaoClasse = ClasseAtualizada.DescricaoClasse;
            }
            else if (ClasseBuscada.NomeClasse != null)
            {
                ClasseBuscada.NomeClasse = ClasseAtualizada.NomeClasse;
            }
            else if (ClasseBuscada.Mana != 0)
            {
                ClasseBuscada.Mana = ClasseAtualizada.Mana;
            }
            else if (ClasseBuscada.Vida != 0)
            {
                ClasseBuscada.Vida = ClasseAtualizada.Vida;
            }

            ctx.Classes.Update(ClasseBuscada);

            ctx.SaveChanges();
        }

        public Classe Buscar(int id)
        {
            return ctx.Classes.FirstOrDefault(C => C.IdClasse == id);
        }

        public void Cadastrar(Classe ClasseNova)
        {
            ctx.Classes.Add(ClasseNova);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Classe ClasseBuscada = Buscar(id);

            ctx.Classes.Remove(ClasseBuscada);

            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}
