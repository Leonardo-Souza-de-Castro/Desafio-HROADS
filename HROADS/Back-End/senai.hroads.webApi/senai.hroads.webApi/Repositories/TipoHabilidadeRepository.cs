using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {

        HroadsContext Ctx = new HroadsContext();

        public void Atualizar(int IdIdTipoHabilidade, TiposHabilidade TipoHabilidadeAtualizado)
        {
            TiposHabilidade TipoHabilidadeBuscado = BuscarPorId(IdIdTipoHabilidade);

            if (TipoHabilidadeAtualizado.TipoHabilidade != null)
            {
                TipoHabilidadeBuscado.TipoHabilidade = TipoHabilidadeAtualizado.TipoHabilidade;
            }

            Ctx.TiposHabilidades.Update(TipoHabilidadeBuscado);

            Ctx.SaveChanges();
        }

        public TiposHabilidade BuscarPorId(int IdTipoHabilidade)
        {
            return Ctx.TiposHabilidades.FirstOrDefault(e => e.IdTipo == IdTipoHabilidade);
        }

        public void Cadastrar(TiposHabilidade NovoTipoHabilidade)
        {
            Ctx.TiposHabilidades.Add(NovoTipoHabilidade);

            Ctx.SaveChanges();
        }

        public void Deletar(int IdTipoHabilidade)
        {
            TiposHabilidade TipoHabilidadeBuscado = BuscarPorId(IdTipoHabilidade);

            Ctx.TiposHabilidades.Remove(TipoHabilidadeBuscado);

            Ctx.SaveChanges();
        }

        public List<TiposHabilidade> ListarTodos()
        {
            return Ctx.TiposHabilidades.ToList();
        }
    }
}
