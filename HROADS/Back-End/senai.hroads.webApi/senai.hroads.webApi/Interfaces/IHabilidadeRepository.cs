using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();

        Habilidade Buscar(int id);

        void Deletar(int id);

        void Atualizar(int id, Habilidade HabilidadeAtualizada);

        void Cadastrar(Habilidade HabilidadeNova);
    }
}
