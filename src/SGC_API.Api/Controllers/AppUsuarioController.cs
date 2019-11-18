using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Entity.AppUsuarioAssociacao;
using SGC_API.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGC_API.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUsuarioController : ControllerBase
    {
        private readonly IAppUsuarioService _appUsuarioService;
        private readonly IUsuarioService _usuarioService;
        private readonly IClienteService _clienteService;
        private readonly IAppService _appService;

        public AppUsuarioController(IAppUsuarioService appUsuarioService,
            IUsuarioService usuarioService,
            IClienteService clienteService,
            IAppService appService)
        {
            _appUsuarioService = appUsuarioService;
            _usuarioService = usuarioService;
            _clienteService = clienteService;
            _appService = appService;
        }

        [HttpGet("BuscarUsuariosSelecionados/{appId}")]
        public IQueryable<Usuario> BuscarUsuariosSelecionados(int appId)
        {
            var appsUsuarios = _appUsuarioService.Buscar(_ => _.AppId == appId);
            return appsUsuarios.Select(_ => _.Usuario);
        }

        [HttpGet("BuscarUsuariosDisponiveis/{appId}")]
        public IQueryable<Usuario> BuscarUsuariosDisponiveis(int appId)
        {
            //var cliente = _clienteService.Buscar(_ => _.Id == GetUsuarioLogado()).FirstOrDefault();
            var usuariosCliente = _usuarioService.Buscar(_ => _.Cliente.Id == GetUsuarioLogado());
            var appsUsuarios = _appUsuarioService.Buscar(_ => _.AppId == appId).Select(_ => _.Usuario);
            
            var usuariosDisponiveis = usuariosCliente.Except(appsUsuarios);

            return usuariosDisponiveis;
        }

        [HttpPut("AtualizarAssociacao")]
        public void AtualizarAssociacao([FromBody]dynamic listaUsuarios)
        {
            AppUsuario appUsuario;

            var usuarios = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Usuario>>(listaUsuarios.usuarios.ToString());
            var usuarioAssociacao = listaUsuarios.ToObject<AppUsuarioAssociacao>();
            int appId = usuarioAssociacao.AppId;
            bool usuarioSelecionado = usuarioAssociacao.UsuarioSelecionado;

            if (usuarioSelecionado)
            {
                var appUsuarios = _appUsuarioService.Buscar(_ => _.AppId == appId).ToList();
                foreach(AppUsuario ap in appUsuarios)
                {
                    _appUsuarioService.Remover(ap.AppId, ap.UsuarioId);
                }                

                foreach (Usuario u in usuarios)
                {
                    appUsuario = new AppUsuario
                    {
                        AppId = appId,
                        UsuarioId = u.Id
                    };
                    _appUsuarioService.Adicionar(appUsuario);
                }
            }
            else
            {
                foreach (Usuario u in usuarios)
                {
                    appUsuario = _appUsuarioService.Buscar(_ => _.AppId == appId && _.UsuarioId == u.Id).FirstOrDefault();
                    _appUsuarioService.Remover(appUsuario.AppId, appUsuario.UsuarioId);
                }
            }
        }

        [HttpGet("ObterTodos")]
        public IQueryable<AppUsuario> ObterTodos()
        {
            return _appUsuarioService.ObterTodos();
        }

        [HttpGet("ObterPorId/{id}")]
        public AppUsuario ObterPorId(int id)
        {
            return _appUsuarioService.ObterPorId(id);
        }

        [HttpGet("Buscar")]
        public IQueryable<AppUsuario> Buscar(Expression<Func<AppUsuario, bool>> predicado)
        {
            return _appUsuarioService.Buscar(predicado);
        }

        [HttpPost]
        public AppUsuario Adicionar([FromBody]AppUsuario appUsuario)
        {
            appUsuario.UsuarioCadastro = GetUsuarioLogado();
            appUsuario.DataCadastro = DateTime.Now;
            appUsuario.Status = true;
            return _appUsuarioService.Adicionar(appUsuario);
        }

        [HttpPut]
        public void Atualizar([FromBody]AppUsuario appUsuario)
        {
            _appUsuarioService.Atualizar(appUsuario);
        }

        [HttpDelete("{id}")]
        public void Remover(int appId, int usuarioId)
        {
            _appUsuarioService.Remover(appId, usuarioId);
        }

        private int GetUsuarioLogado()
        {
            int idCliente = 0;

            if (User.Identity.Name != null)
            {
                int.TryParse(User.Identity.Name, out idCliente);
            }

            return idCliente;
        }
    }
}
