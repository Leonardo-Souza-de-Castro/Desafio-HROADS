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
    public class StatusPersonagenRepository : IStatusPersonagenRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, StatusPersonagen StatusAtualizado)
        {
            StatusPersonagen StatusBuscado = Buscar(id);

            if (StatusBuscado.IdClasse != null)
            {
                StatusBuscado.IdClasse = StatusAtualizado.IdClasse;
            }
            else if (StatusBuscado.IdHabilidade != null)
            {
                StatusBuscado.IdHabilidade = StatusAtualizado.IdHabilidade;
            }

            ctx.StatusPersonagens.Update(StatusBuscado);

            ctx.SaveChanges();
        }

        public StatusPersonagen Buscar(int id)
        {
            return ctx.StatusPersonagens.FirstOrDefault(S => S.IdStatus == id);
        }

        public void Cadastrar(StatusPersonagen StatusNovo)
        {
            ctx.StatusPersonagens.Add(StatusNovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            StatusPersonagen StatusBuscado = Buscar(id);

            if (StatusBuscado != null)
            {
                ctx.StatusPersonagens.Remove(StatusBuscado);

                ctx.SaveChanges();
            }
        }

        public List<StatusPersonagen> Listar()
        {
            return ctx.StatusPersonagens.Include(S => S.IdHabilidadeNavigation).Include(S => S.IdClasseNavigation).ToList();
        }
    }
}
