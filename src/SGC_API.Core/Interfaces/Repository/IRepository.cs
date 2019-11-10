using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);
        IEnumerable<TEntity> ObterTodos();
        void Remover(TEntity entity);
    }
}
