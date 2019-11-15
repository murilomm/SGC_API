using Microsoft.EntityFrameworkCore;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ClienteContext _dbContext;

        public EFRepository(ClienteContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual TEntity Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public virtual void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IQueryable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado);
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>();
        }

        public void Remover(int id)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
