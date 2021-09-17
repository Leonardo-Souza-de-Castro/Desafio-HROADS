using senai.hroads.webApi.Domains;
using System.Collections.Generic;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();

        Usuario BuscarPorId(int IdUsuario);

        void Cadastrar(Usuario NovoUsuario);

        void Atualizar(int IdUsuario, Usuario UsuarioAtualizado);

        void Deletar(int IdUsuario);
    }
}
