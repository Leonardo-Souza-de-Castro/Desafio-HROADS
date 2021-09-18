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
    [Produces ("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadeController : ControllerBase
    {
        private IHabilidadeRepository _HabiliadeRepository { get; set; }

        public HabilidadeController()
        {
            _HabiliadeRepository = new HabilidadeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_HabiliadeRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            return Ok(_HabiliadeRepository.Buscar(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Habilidade HabiliadeNova)
        {
            _HabiliadeRepository.Cadastrar(HabiliadeNova);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Habilidade HabilidadeAtualizada)
        {
            _HabiliadeRepository.Atualizar(id, HabilidadeAtualizada);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _HabiliadeRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}
