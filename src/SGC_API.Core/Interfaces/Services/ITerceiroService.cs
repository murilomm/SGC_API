using SGC_API.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface ITerceiroService
    {
        Terceiro Adicionar(Terceiro entity);
        void Atualizar(Terceiro entity);
        Terceiro ObterPorId(int id);
        IQueryable<Terceiro> Buscar(Expression<Func<Terceiro, bool>> predicado);
        IQueryable<Terceiro> ObterTodos();
        void Remover(int id);
    }
}
