using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Repository;
using SGC_API.Core.Interfaces.Services;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SGC_API.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly AppSettings _appSettings;
        private readonly IClienteRepository _clienteRepository;

        public LoginService(IClienteRepository clienteRepository, IOptions<AppSettings> appSettings)
        {
            _clienteRepository = clienteRepository;
            _appSettings = appSettings.Value;
        }

        public Cliente Autenticar(string cpf, string senha)
        {            
            // busca usuário por login e senha
            var cliente = _clienteRepository.ObterPorLoginSenha(cpf, senha);

            // retorna nulo se não encontrar o usuário
            if (cliente == null)
                return null;

            // Geração do token JWT
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, cliente.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            cliente.Token = tokenHandler.WriteToken(token);

            // remove senha antes de retornar
            cliente.Senha = null;

            return cliente;
        }        
    }
}
