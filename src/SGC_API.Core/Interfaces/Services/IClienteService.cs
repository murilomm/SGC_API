using SGC_API.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        Cliente ObterPorId(int id);
        Cliente ObterPorLoginSenha(string cpf, string senha);
        IQueryable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        IQueryable<Cliente> ObterTodos();
        void Remover(int id);
    }
}
