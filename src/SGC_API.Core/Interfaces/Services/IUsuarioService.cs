using SGC_API.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface IUsuarioService
    {
        Usuario Adicionar(Usuario entity);
        void Atualizar(Usuario entity);
        Usuario ObterPorId(int id);
        IQueryable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado);
        IQueryable<Usuario> ObterTodos();
        void Remover(int id);
    }
}
