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
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            return _clienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            _clienteRepository.Atualizar(entity);
        }

        public Cliente ObterPorLoginSenha(string cpf, string senha)
        {
            return _clienteRepository.ObterPorLoginSenha(cpf, senha);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}
