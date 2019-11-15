using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Linq;
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
            entity.DataCadastro = DateTime.Now;
            return _clienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
            entity.DataAlteracao = DateTime.Now;
            _clienteRepository.Atualizar(entity);
        }

        public Cliente ObterPorLoginSenha(string cpf, string senha)
        {
            return _clienteRepository.ObterPorLoginSenha(cpf, senha);
        }

        public IQueryable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IQueryable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _clienteRepository.Remover(id);
        }
    }
}
