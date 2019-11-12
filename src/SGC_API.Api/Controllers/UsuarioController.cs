using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }        

        [HttpGet]
        public IEnumerable<Usuario> ObterTodos()
        {
            return _usuarioService.ObterTodos();
        }

        [HttpGet("ObterPorId/{id}")]
        public Usuario ObterPorId(int id)
        {
            return _usuarioService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IEnumerable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado)
        {
            return _usuarioService.Buscar(predicado);
        }

        [HttpPost]
        public Usuario Adicionar(Usuario usuario)
        {
            return _usuarioService.Adicionar(usuario);
        }

        [HttpPut]
        public void Atualizar(Usuario usuario)
        {
            _usuarioService.Atualizar(usuario);
        }

        [HttpDelete]
        public void Remover(Usuario usuario)
        {   
            _usuarioService.Remover(usuario);
        }
    }
}
