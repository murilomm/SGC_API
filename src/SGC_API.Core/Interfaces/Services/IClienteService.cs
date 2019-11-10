using SGC_API.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface IClienteService
    {
        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        IEnumerable<Cliente> ObterTodos();
        void Remover(Cliente entity);
    }
}
