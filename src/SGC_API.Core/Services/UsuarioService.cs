using Microsoft.Extensions.Options;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppSettings _appSettings;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, IOptions<AppSettings> appSettings)
        {
            _usuarioRepository = usuarioRepository;
            _appSettings = appSettings.Value;
        }

        public Usuario Adicionar(Usuario entity)
        {
            entity.DataCadastro = DateTime.Now;
            return _usuarioRepository.Adicionar(entity);
        }

        public void Atualizar(Usuario entity)
        {
            entity.DataAlteracao = DateTime.Now;
            _usuarioRepository.Atualizar(entity);
        }

        public IQueryable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado)
        {
            return _usuarioRepository.Buscar(predicado);
        }

        public Usuario ObterPorId(int id)
        {
            return _usuarioRepository.ObterPorId(id);
        }

        public IQueryable<Usuario> ObterTodos()
        {
            return _usuarioRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _usuarioRepository.Remover(id);
        }
    }
}
