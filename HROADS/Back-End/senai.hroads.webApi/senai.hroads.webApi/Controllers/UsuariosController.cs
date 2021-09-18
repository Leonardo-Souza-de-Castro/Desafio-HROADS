using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]

    public class UsuariosController : ControllerBase
    {
        //Objeto _UsuarioRepository que irá receber todos os métodos definidos na interface IUsuarioRepository
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuariosController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_UsuarioRepository.ListarTodos());
        }

        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id)
        {
            return Ok(_UsuarioRepository.BuscarPorId(Id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Usuario NovoUsuario)
        {
            _UsuarioRepository.Cadastrar(NovoUsuario);

            return StatusCode(201);
        }
        

        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, Usuario UsuarioAtualizado)
        {
            _UsuarioRepository.Atualizar(Id, UsuarioAtualizado);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            _UsuarioRepository.Deletar(Id);

            return Ok();
        }
    }
}
