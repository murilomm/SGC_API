using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Services
{
    public class AppService : IAppService
    {
        private readonly IAppRepository _appRepository;

        public AppService(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }

        public App Adicionar(App entity)
        {
            return _appRepository.Adicionar(entity);
        }

        public void Atualizar(App entity)
        {
            _appRepository.Atualizar(entity);
        }

        public IEnumerable<App> Buscar(Expression<Func<App, bool>> predicado)
        {
            return _appRepository.Buscar(predicado);
        }

        public App ObterPorId(int id)
        {
            return _appRepository.ObterPorId(id);
        }

        public IEnumerable<App> ObterTodos()
        {
            return _appRepository.ObterTodos();
        }

        public void Remover(App entity)
        {
            _appRepository.Remover(entity);
        }
    }
}
