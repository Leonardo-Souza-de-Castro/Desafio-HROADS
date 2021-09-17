using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TiposHabilidade> ListarTodos();

        TiposHabilidade BuscarPorId(int IdTipoHabilidade);

        void Cadastrar(TiposHabilidade NovoTipoHabilidade);

        void Atualizar(int IdIdTipoHabilidade, TiposHabilidade TipoHabilidadeAtualizado);

        void Deletar(int IdTipoHabilidade);
    }
}
