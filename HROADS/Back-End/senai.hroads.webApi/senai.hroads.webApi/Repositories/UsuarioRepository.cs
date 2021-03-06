using Microsoft.EntityFrameworkCore;
using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai.hroads.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadsContext Ctx = new HroadsContext();

        public void Atualizar(int IdUsuario, Usuario UsuarioAtualizado)
        {
            // Jeito 1= Usuario UsuarioBuscado = Ctx.Usuarios.Find(IdUsuario);

            Usuario UsuarioBuscado = BuscarPorId(IdUsuario);

            if (UsuarioAtualizado.NomeUsuario != null)
            {
                UsuarioBuscado.NomeUsuario = UsuarioAtualizado.NomeUsuario;
            }

            if (UsuarioAtualizado.Email != null)
            {
                UsuarioBuscado.Email = UsuarioAtualizado.Email;
            }

            if (UsuarioAtualizado.Senha != null)
            {
                UsuarioBuscado.Senha = UsuarioAtualizado.Senha;
            }

            if (UsuarioAtualizado.IdTipoUsuario != null)
            {
                UsuarioBuscado.IdTipoUsuario = UsuarioAtualizado.IdTipoUsuario;
            }

            Ctx.Usuarios.Update(UsuarioBuscado);

            Ctx.SaveChanges();
        }

        public Usuario BuscarPorEmailSenha(string Email, string Senha)
        {
                return Ctx.Usuarios.FirstOrDefault(e => e.Email == Email && e.Senha == Senha);
        }

        public Usuario BuscarPorId(int IdUsuario)
        {
            // Retorna o primeiro usuário encontrado  para o Id informado
            return Ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == IdUsuario);
        }

        public void Cadastrar(Usuario NovoUsuario)
        {
            Ctx.Usuarios.Add(NovoUsuario);

            // Como estamos fazendo alterações, precisamos salva-las.
            Ctx.SaveChanges();
        }

        public void Deletar(int IdUsuario)
        {
            Usuario UsuarioBuscado = BuscarPorId(IdUsuario);

            Ctx.Usuarios.Remove(UsuarioBuscado);

            Ctx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return Ctx.Usuarios
                .Select(u => new Usuario(){ 
                    Email = u.Email, 
                    NomeUsuario = u.NomeUsuario, 
                    IdTipoUsuarioNavigation = new TiposUsuario()
                    {
                        Titulo = u.IdTipoUsuarioNavigation.Titulo
                    }
                })
                .ToList();
        }

        public Usuario Login (string Email, string Senha) 
        {
            return Ctx.Usuarios.FirstOrDefault(e => e.Email == Email && e.Senha == Senha);
        }
    }
}
