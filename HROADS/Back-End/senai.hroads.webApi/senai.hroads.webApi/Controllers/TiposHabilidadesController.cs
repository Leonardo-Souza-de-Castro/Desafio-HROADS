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

    public class TiposHabilidadesController : ControllerBase
    {
        private ITipoHabilidadeRepository _TiposHabilidadesRepository { get; set; }

        public TiposHabilidadesController()
        {
            _TiposHabilidadesRepository = new TipoHabilidadeRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_TiposHabilidadesRepository.ListarTodos());
        }

        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id)
        {
            return Ok(_TiposHabilidadesRepository.BuscarPorId(Id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(TiposHabilidade NovoTipoHabilidade)
        {
            _TiposHabilidadesRepository.Cadastrar(NovoTipoHabilidade);

            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult Atualizar(int Id, TiposHabilidade TipoHabilidadeAtualizado)
        {
            _TiposHabilidadesRepository.Atualizar(Id, TipoHabilidadeAtualizado);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            _TiposHabilidadesRepository.Deletar(Id);

            return Ok();
        }
    }
}
