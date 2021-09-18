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
    [Authorize(Roles = "1")]
    public class StatusPersonagemController : ControllerBase
    {
        private IStatusPersonagenRepository _StatusPersonagem { get; set; }

        public StatusPersonagemController()
        {
            _StatusPersonagem = new StatusPersonagenRepository();
        } 

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_StatusPersonagem.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            return Ok(_StatusPersonagem.Buscar(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(StatusPersonagen StatusNovo)
        {
            _StatusPersonagem.Cadastrar(StatusNovo);
            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, StatusPersonagen StatusAtualizado)
        {
            _StatusPersonagem.Atualizar(id, StatusAtualizado);
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _StatusPersonagem.Deletar(id);
            return StatusCode(204);
        }
    }
}
