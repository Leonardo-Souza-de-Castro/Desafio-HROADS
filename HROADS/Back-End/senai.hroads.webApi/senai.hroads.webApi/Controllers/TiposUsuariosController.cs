using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;

namespace senai.hroads.webApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]

    public class TiposUsuariosController : ControllerBase
    {
        private ITipoUsuarioRepository _TiposUsuariosRepository { get; set; }

        public TiposUsuariosController()
        {
            _TiposUsuariosRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_TiposUsuariosRepository.ListarTodos());
        }

        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id)
        {
            return Ok(_TiposUsuariosRepository.BuscarPorId(Id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(TiposUsuario NovoTipoUsuario)
        {
            _TiposUsuariosRepository.Cadastrar(NovoTipoUsuario);

            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, TiposUsuario TipoUsuarioAtualizado)
        {
            _TiposUsuariosRepository.Atualizar(Id, TipoUsuarioAtualizado);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            _TiposUsuariosRepository.Deletar(Id);

            return Ok();
        }
    }
}
