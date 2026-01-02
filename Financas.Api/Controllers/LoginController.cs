using Financas.Negocio.EntidadeVO;
using Financas.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace financas_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService service;
        private readonly INegocioUsuario negocio;
        public LoginController(IAuthService service, INegocioUsuario negocio)
        {
            this.service = service;
            this.negocio = negocio;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UsuarioVO loginRequest) 
        {
            var usuario = await negocio.ObterUsuarioPorEmailSenha(loginRequest.Email, loginRequest.Senha);

            if (usuario != null)
            {
                var token = service.GeradorJwtToken(loginRequest.Email, loginRequest.Senha);
                return Ok(new { Token = token });
            }
            return Unauthorized("Usuário inexistente ou com e-mail ou senha inválidos");
        }
    }
}
