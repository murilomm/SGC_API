using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;

namespace SGC_API.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private readonly IAppService _appService;
        private readonly IClienteService _clienteService;

        public AppController(IAppService appService,
            IClienteService clienteService)
        {
            _appService = appService;
            _clienteService = clienteService;
        }

        [HttpGet("ObterTodos")]
        public IQueryable<App> ObterTodos()
        {
            return _appService.ObterTodos();
        }

        [HttpGet("ObterClienteApps")]
        public IQueryable<App> ObterClienteApps()
        {
            return _appService.Buscar(_ => _.Cliente.Id == GetUsuarioLogado());
        }

        [HttpGet("ObterPorId/{id}")]
        public App ObterPorId(int id)
        {
            return _appService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IQueryable<App> Buscar(Expression<Func<App, bool>> predicado)
        {
            return _appService.Buscar(predicado);
        }

        [HttpPost]
        public App Adicionar([FromBody]App app)
        {
            Cliente c = _clienteService.ObterPorId(GetUsuarioLogado());
            app.Cliente = c;
            
            return _appService.Adicionar(app);
        }

        [HttpPut]
        public void Atualizar([FromBody]App app)
        {
            _appService.Atualizar(app);
        }

        [HttpDelete("{id}")]
        public void Remover(int id)
        {
            _appService.Remover(id);
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
