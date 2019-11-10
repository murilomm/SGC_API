using SGC_API.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface IUsuarioService
    {
        Usuario Adicionar(Usuario entity);
        void Atualizar(Usuario entity);
        Usuario ObterPorId(int id);
        IEnumerable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado);
        IEnumerable<Usuario> ObterTodos();
        void Remover(Usuario entity);
    }
}
