using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Habilidade HabilidadeAtualizada)
        {
            Habilidade HabilidadeBuscada = Buscar(id);

            if (HabilidadeBuscada.NomeHabilidade != null)
            {
                HabilidadeBuscada.NomeHabilidade = HabilidadeAtualizada.NomeHabilidade;
            }
            else if (HabilidadeBuscada.IdTipo != null)
            {
                HabilidadeBuscada.IdTipo = HabilidadeAtualizada.IdTipo;
            }
            else if (HabilidadeBuscada.DescricaoHabilidade != null)
            {
                HabilidadeBuscada.DescricaoHabilidade = HabilidadeAtualizada.DescricaoHabilidade;
            }
        
            ctx.Habilidades.Update(HabilidadeBuscada);

            ctx.SaveChanges();
        }

        public Habilidade Buscar(int id)
        {
            return ctx.Habilidades.FirstOrDefault(H => H.IdHabilidade == id);
        }

        public void Cadastrar(Habilidade HabilidadeNova)
        {
            ctx.Habilidades.Add(HabilidadeNova);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Habilidade HabilidadeBuscada = Buscar(id);

            ctx.Habilidades.Remove(HabilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
