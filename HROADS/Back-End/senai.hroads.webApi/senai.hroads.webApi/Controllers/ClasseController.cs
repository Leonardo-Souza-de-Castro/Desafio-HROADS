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
    public class ClasseController : ControllerBase
    {
        private IClasseRepository _ClasseRepository { get; set; }

        public ClasseController()
        {
            _ClasseRepository = new ClasseRepository();
        }

        
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_ClasseRepository.Listar());
        }

        [HttpGet ("{id}")]
        public IActionResult Buscar(int id)
        {
            return Ok(_ClasseRepository.Buscar(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Classe ClasseNova)
        {
            _ClasseRepository.Cadastrar(ClasseNova);

            return StatusCode(201);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Classe ClasseAtualizada)
        {
            _ClasseRepository.Atualizar(id, ClasseAtualizada);

            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpDelete ("{id}")]
        public IActionResult Deletar(int id)
        {
            _ClasseRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
