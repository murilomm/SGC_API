using SGC_API.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface ITerceiroService
    {
        Terceiro Adicionar(Terceiro entity);
        void Atualizar(Terceiro entity);
        Terceiro ObterPorId(int id);
        IEnumerable<Terceiro> Buscar(Expression<Func<Terceiro, bool>> predicado);
        IEnumerable<Terceiro> ObterTodos();
        void Remover(Terceiro entity);
    }
}
