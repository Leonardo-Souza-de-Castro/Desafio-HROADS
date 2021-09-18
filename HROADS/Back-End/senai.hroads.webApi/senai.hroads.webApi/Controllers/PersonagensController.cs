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
    public class PersonagensController : ControllerBase
    {
        private IPersonagenRepository _PersonagenRepository { get; set; }

        public PersonagensController()
        {
            _PersonagenRepository = new PersonagenRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_PersonagenRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult Buscar(int id)
        {
            Personagen PersonagenBuscado = _PersonagenRepository.Buscar(id);
            if (PersonagenBuscado == null)
            {
                return NotFound("Nenhum jogo encontrado");
            }
            return Ok(PersonagenBuscado);
        }

        [HttpPost]
        public IActionResult Cadastrar(Personagen PersonagenNovo)
        {
            _PersonagenRepository.Cadastrar(PersonagenNovo);
            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Personagen PersonagenAtualizado)
        {
            _PersonagenRepository.Atualizar(id, PersonagenAtualizado);
            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _PersonagenRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}
