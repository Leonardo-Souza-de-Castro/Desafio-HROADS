using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        HroadsContext Ctx = new HroadsContext();

        public void Atualizar(int IdTipoUsuario, TiposUsuario TipoUsuarioAtualizado)
        {
            TiposUsuario TipoUsuarioBuscado = BuscarPorId(IdTipoUsuario);

            if (TipoUsuarioAtualizado.Titulo != null)
            {
                TipoUsuarioBuscado.Titulo = TipoUsuarioAtualizado.Titulo;
            }

            Ctx.TiposUsuarios.Update(TipoUsuarioBuscado);

            Ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(int IdTipoUsuario)
        {
            return Ctx.TiposUsuarios.FirstOrDefault(e => e.IdTipoUsuario == IdTipoUsuario);
        }

        public void Cadastrar(TiposUsuario NovoTipoUsuario)
        {
            Ctx.TiposUsuarios.Add(NovoTipoUsuario);

            Ctx.SaveChanges();
        }

        public void Deletar(int IdTipoUsuario)
        {
            TiposUsuario TipoUsuarioBuscado = BuscarPorId(IdTipoUsuario);

            Ctx.TiposUsuarios.Remove(TipoUsuarioBuscado);

            Ctx.SaveChanges();
        }

        public List<TiposUsuario> ListarTodos()
        {
            return Ctx.TiposUsuarios.ToList();
        }
    }
}
