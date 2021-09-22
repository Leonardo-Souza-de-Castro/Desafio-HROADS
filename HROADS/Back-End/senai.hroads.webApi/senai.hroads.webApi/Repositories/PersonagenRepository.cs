using Microsoft.EntityFrameworkCore;
using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class PersonagenRepository : IPersonagenRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Personagen PersonagemAtualizado)
        {
            Personagen PersonagenBuscado = Buscar(id);

            if (PersonagenBuscado.NomePersonagem != null)
            {
                PersonagenBuscado.NomePersonagem = PersonagemAtualizado.NomePersonagem;
            }

            ctx.Personagens.Update(PersonagenBuscado);

            ctx.SaveChanges();
        }

        public Personagen Buscar(int id)
        {
            return ctx.Personagens.FirstOrDefault(P => P.IdPersonagem == id);

        }

        public void Cadastrar(Personagen PersonagenNovo)
        {
            ctx.Personagens.Add(PersonagenNovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Personagen PersonagenBuscado = Buscar(id);

            ctx.Personagens.Remove(PersonagenBuscado);

            ctx.SaveChanges();
        }

        public List<Personagen> Listar()
        {
            return ctx.Personagens.Include(p => p.IdClasseNavigation).OrderBy(C => C.IdClasseNavigation.NomeClasse).ToList();
        }

        // public List<Personagen> ListarComJogador()
        //{
          //  return ctx.Personagens.Include(p => p.IdClasseNavigation).ToList();
        //}

        
    }
}
