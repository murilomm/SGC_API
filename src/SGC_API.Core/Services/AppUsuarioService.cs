using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Services
{
    public class AppUsuarioService : IAppUsuarioService
    {
        private readonly IAppUsuarioRepository _appUsuarioRepository;

        public AppUsuarioService(IAppUsuarioRepository appUsuarioRepository)
        {
            _appUsuarioRepository = appUsuarioRepository;
        }

        public AppUsuario Adicionar(AppUsuario entity)
        {
            entity.DataCadastro = DateTime.Now;
            return _appUsuarioRepository.Adicionar(entity);
        }

        public void Atualizar(AppUsuario entity)
        {
            entity.DataAlteracao = DateTime.Now;
            _appUsuarioRepository.Atualizar(entity);
        }

        public IQueryable<AppUsuario> Buscar(Expression<Func<AppUsuario, bool>> predicado)
        {
            return _appUsuarioRepository.Buscar(predicado);
        }

        public AppUsuario ObterPorId(int id)
        {
            return _appUsuarioRepository.ObterPorId(id);
        }

        public IQueryable<AppUsuario> ObterTodos()
        {
            return _appUsuarioRepository.ObterTodos();
        }

        public void Remover(int appId, int usuarioId)
        {
            _appUsuarioRepository.Remover(appId, usuarioId);
        }
    }
}
