using SGC_API.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Interfaces.Services
{
    public interface IAppUsuarioService
    {
        AppUsuario Adicionar(AppUsuario entity);
        void Atualizar(AppUsuario entity);
        AppUsuario ObterPorId(int id);
        IQueryable<AppUsuario> Buscar(Expression<Func<AppUsuario, bool>> predicado);
        IQueryable<AppUsuario> ObterTodos();
        void Remover(int appId, int usuarioId);
    }
}
