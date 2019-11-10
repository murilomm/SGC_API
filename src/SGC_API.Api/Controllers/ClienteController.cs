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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService ClienteService)
        {
            _clienteService = ClienteService;
        }

        [HttpGet]
        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteService.ObterTodos();
        }

        [HttpGet("ObterPorId/{id}")]
        public Cliente ObterPorId(int id)
        {
            return _clienteService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteService.Buscar(predicado);
        }

        [HttpPost]
        public Cliente Adicionar(Cliente Cliente)
        {
            return _clienteService.Adicionar(Cliente);
        }

        [HttpPut]
        public void Atualizar(Cliente Cliente)
        {
            _clienteService.Atualizar(Cliente);
        }

        [HttpDelete]
        public void Remover(Cliente Cliente)
        {   
            _clienteService.Remover(Cliente);
        }
    }
}
