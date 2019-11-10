﻿using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TerceiroController : ControllerBase
    {
        private readonly ITerceiroService _terceiroService;

        public TerceiroController(ITerceiroService TerceiroService)
        {
            _terceiroService = TerceiroService;
        }

        [HttpGet]
        public IEnumerable<Terceiro> ObterTodos()
        {
            return _terceiroService.ObterTodos();
        }

        [HttpGet("ObterPorId/{id}")]
        public Terceiro ObterPorId(int id)
        {
            return _terceiroService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IEnumerable<Terceiro> Buscar(Expression<Func<Terceiro, bool>> predicado)
        {
            return _terceiroService.Buscar(predicado);
        }

        [HttpPost]
        public Terceiro Adicionar(Terceiro Terceiro)
        {
            return _terceiroService.Adicionar(Terceiro);
        }

        [HttpPut]
        public void Atualizar(Terceiro Terceiro)
        {
            _terceiroService.Atualizar(Terceiro);
        }

        [HttpDelete]
        public void Remover(Terceiro Terceiro)
        {   
            _terceiroService.Remover(Terceiro);
        }
    }
}
