using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClasseRepository
    {
        /// <summary>
        /// Método Responsavel por listar todas as Classes
        /// </summary>
        /// <returns>Retorna uma lista de Classes</returns>
        List<Classe> Listar();

        /// <summary>
        /// Método reponsavel por buscar uma classe pelo id
        /// </summary>
        /// <param name="id">Id da classe buscada</param>
        /// <returns>Retorna a classe com o id buscado</returns>
        Classe Buscar(int id);

        /// <summary>
        /// Método que deleta uma classe
        /// </summary>
        /// <param name="id">Id da classe a ser deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Método responsavel por atualizar uma classe
        /// </summary>
        /// <param name="id">Id da classe a ser atualizada</param>
        /// <param name="ClasseAtualizada">Novos valores para atualização</param>
        void Atualizar(int id, Classe ClasseAtualizada);

        /// <summary>
        /// Méotod que cadastra uma nova classe
        /// </summary>
        /// <param name="ClasseNova">Nova classe a ser cadastrada</param>
        void Cadastrar(Classe ClasseNova);
    }
}
