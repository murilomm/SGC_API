using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        TEntity ObterPorId(int id);
        IQueryable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);
        IQueryable<TEntity> ObterTodos();
        void Remover(int id);
    }
}
