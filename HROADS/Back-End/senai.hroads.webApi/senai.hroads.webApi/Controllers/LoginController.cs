using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _UsuarioRepository { get; set; }

        public LoginController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(Usuario Login)
        {
            Usuario UsuarioBuscado = _UsuarioRepository.BuscarPorEmailSenha(Login.Email, Login.Senha);


            if (UsuarioBuscado != null)
            {
                var Claims = new[]
                {
                    new Claim (JwtRegisteredClaimNames.Email, UsuarioBuscado.Email),
                    new Claim (JwtRegisteredClaimNames.Jti, UsuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, UsuarioBuscado.IdTipoUsuario.ToString())
                };

                // Chave
                var Key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("jogo-hroads-chave-autenticar"));

                var Creds = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

                var MeuToken = new JwtSecurityToken(
                               issuer: "hroads.webApi",                // emissor do token
                               audience: "hroads.webApi",              // destinatário do token
                               claims: Claims,                         // dados que foram definidos acima (linha 38)
                               expires: DateTime.Now.AddHours(5),      // tempo de expiração do token
                               signingCredentials: Creds               // credenciais do token
                    );

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(MeuToken)
                });
            }

            return NotFound("Email ou senha inválidos");
        }
    }
}
