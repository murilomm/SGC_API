using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

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
            return _usuarioRepository.Adicionar(entity);
        }

        public void Atualizar(Usuario entity)
        {
            _usuarioRepository.Atualizar(entity);
        }

        public IEnumerable<Usuario> Buscar(Expression<Func<Usuario, bool>> predicado)
        {
            return _usuarioRepository.Buscar(predicado);
        }

        public Usuario ObterPorId(int id)
        {
            return _usuarioRepository.ObterPorId(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _usuarioRepository.ObterTodos();
        }

        public void Remover(Usuario entity)
        {
            _usuarioRepository.Remover(entity);
        }
    }
}
