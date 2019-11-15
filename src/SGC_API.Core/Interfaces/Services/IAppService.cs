using SGC_API.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface IAppService
    {
        App Adicionar(App entity);
        void Atualizar(App entity);
        App ObterPorId(int id);
        IQueryable<App> Buscar(Expression<Func<App, bool>> predicado);
        IQueryable<App> ObterTodos();
        void Remover(int id);
    }
}
