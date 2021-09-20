using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IPersonagenRepository
    {
        List<Personagen> Listar();

        //List<Personagen> ListarComJogador();

        Personagen Buscar(int id);

        void Deletar(int id);

        void Atualizar(int id, Personagen PersonagemAtualizado);

        void Cadastrar(Personagen PersonagenNovo);
    }
}
