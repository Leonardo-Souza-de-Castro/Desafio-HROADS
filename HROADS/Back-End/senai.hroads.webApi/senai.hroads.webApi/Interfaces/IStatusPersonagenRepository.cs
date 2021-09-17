using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IStatusPersonagenRepository
    {
        List<StatusPersonagen> Listar();

        StatusPersonagen Buscar(int id);

        void Deletar(int id);

        void Atualizar(int id, StatusPersonagen StatusAtualizado);

        void Cadastrar(StatusPersonagen StatusNovo);
    }
}
