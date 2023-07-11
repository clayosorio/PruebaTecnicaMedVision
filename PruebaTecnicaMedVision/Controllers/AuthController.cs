using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Models.Response;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class AuthController : ControllerBase
	{
        IPersonaService _personasServices;

		public AuthController(IPersonaService personaService)
        {
			_personasServices = personaService;

		}

        [HttpPost]
        public async Task<IActionResult> Login(string nombreUsuario, string contraseña) 
        {
           var res = await _personasServices.Login(nombreUsuario, contraseña);
            return Ok(res);
        }

	}
}
