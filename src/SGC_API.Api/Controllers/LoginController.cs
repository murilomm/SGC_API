using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGC_API.Core.Entity;
using SGC_API.Core.Interfaces.Services;

namespace SGC_API.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Autenticar([FromBody]Cliente cliente)
        {
            var user = _loginService.Autenticar(cliente.Cpf, cliente.Senha);

            if (user == null)
                return BadRequest(new { message = "CPF ou senha incorreto(s)." });

            return Ok(user);
        }       
    }
}
