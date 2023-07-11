using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Controllers
{

	[ApiController]
	[Route("api/[controller]/[action]")]
	public class PersonaController : ControllerBase
	{
		IPersonaService _personaService;
		public PersonaController(IPersonaService personaService) 
		{
			_personaService = personaService;
		}
		[HttpPost]
		public async Task<IActionResult> AgregarPersona(Persona persona)
		{
			await _personaService.AgregarPersona(persona);
			return Ok();
		}
		[HttpGet]
		public async Task<IActionResult> ObtenerPersonasConCitas()
		{
			var personasConCitas = _personaService.ObtenerPersonasConCitas();
			return Ok(personasConCitas);
		}

	}
}
