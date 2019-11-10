using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _ClienteRepository;

        public ClienteService(IClienteRepository ClienteRepository)
        {
            _ClienteRepository = ClienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            return _ClienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            _ClienteRepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _ClienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _ClienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _ClienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _ClienteRepository.Remover(entity);
        }
    }
}
