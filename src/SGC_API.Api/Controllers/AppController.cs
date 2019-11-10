using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private readonly IAppService _appService;

        public AppController(IAppService AppService)
        {
            _appService = AppService;
        }

        [HttpGet]
        public IEnumerable<App> ObterTodos()
        {
            return _appService.ObterTodos();
        }

        [HttpGet("ObterPorId/{id}")]
        public App ObterPorId(int id)
        {
            return _appService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IEnumerable<App> Buscar(Expression<Func<App, bool>> predicado)
        {
            return _appService.Buscar(predicado);
        }

        [HttpPost]
        public App Adicionar(App App)
        {
            return _appService.Adicionar(App);
        }

        [HttpPut]
        public void Atualizar(App App)
        {
            _appService.Atualizar(App);
        }

        [HttpDelete]
        public void Remover(App App)
        {   
            _appService.Remover(App);
        }
    }
}
