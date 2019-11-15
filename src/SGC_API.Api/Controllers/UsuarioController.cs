using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IAppService _appService;
        private readonly IClienteService _clienteService;

        public UsuarioController(IUsuarioService usuarioService,
            IAppService appService,
            IClienteService clienteService)
        {
            _usuarioService = usuarioService;
            _appService = appService;
            _clienteService = clienteService;
        }

        [HttpGet]
        public IQueryable<Usuario> ObterTodos()
        {
            return _usuarioService.ObterTodos();
        }

        [HttpGet("ObterPorId/{id}")]
        public Usuario ObterPorId(int id)
        {
            return _usuarioService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IQueryable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado)
        {
            return _usuarioService.Buscar(predicado);
        }

        [HttpPost]
        public Usuario Adicionar([FromBody]Usuario usuario)
        {
            Cliente c = _clienteService.ObterPorId(GetUsuarioLogado());
            usuario.Cliente = c;

            return _usuarioService.Adicionar(usuario);
        }

        [HttpPut]
        public void Atualizar([FromBody]Usuario usuario)
        {
            _usuarioService.Atualizar(usuario);
        }

        [HttpDelete("{id}")]
        public void Remover(int id)
        {   
            _usuarioService.Remover(id);
        }

        private int GetUsuarioLogado()
        {
            int idCliente = 0;

            if (User.Identity.Name != null)
            {
                int.TryParse(User.Identity.Name, out idCliente);
            }

            return idCliente;
        }
    }
}
