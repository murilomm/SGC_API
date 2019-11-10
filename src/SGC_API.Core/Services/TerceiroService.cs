using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGC_API.Core.Services
{
    public class TerceiroService : ITerceiroService
    {
        private readonly ITerceiroRepository _TerceiroRepository;

        public TerceiroService(ITerceiroRepository TerceiroRepository)
        {
            _TerceiroRepository = TerceiroRepository;
        }

        public Terceiro Adicionar(Terceiro entity)
        {
            return _TerceiroRepository.Adicionar(entity);
        }

        public void Atualizar(Terceiro entity)
        {
            _TerceiroRepository.Atualizar(entity);
        }

        public IEnumerable<Terceiro> Buscar(Expression<Func<Terceiro, bool>> predicado)
        {
            return _TerceiroRepository.Buscar(predicado);
        }

        public Terceiro ObterPorId(int id)
        {
            return _TerceiroRepository.ObterPorId(id);
        }

        public IEnumerable<Terceiro> ObterTodos()
        {
            return _TerceiroRepository.ObterTodos();
        }

        public void Remover(Terceiro entity)
        {
            _TerceiroRepository.Remover(entity);
        }
    }
}
