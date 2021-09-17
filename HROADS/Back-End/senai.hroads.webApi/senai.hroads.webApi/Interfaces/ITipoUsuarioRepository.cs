using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TiposUsuario> ListarTodos();

        TiposUsuario BuscarPorId(int IdTipoUsuario);

        void Cadastrar(TiposUsuario NovoTipoUsuario);

        void Atualizar(int IdTipoUsuario, TiposUsuario TipoUsuarioAtualizado);

        void Deletar(int IdTipoUsuario);
    }
}
