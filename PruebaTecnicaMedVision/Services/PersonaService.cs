using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Models.Response;
using PruebaTecnicaMedVision.Repositories.IRepositories;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Services
{
	public class PersonaService : IPersonaService
	{
		IPersonaRepository _personaRepository;

		public PersonaService(IPersonaRepository personaRepository)
		{
			_personaRepository = personaRepository;

		}
		public async Task<TokenResponse> Login(string nombreUsuario, string contraseña)
		{
			var res = await _personaRepository.Login(nombreUsuario, contraseña);
			return res;
		}

		public async Task AgregarPersona(Persona persona) 
		{
			await _personaRepository.AgregarPersona(persona);
		}

		public async Task<List<Persona>> ObtenerPersonasConCitas()
		{ 
			var result = _personaRepository.ObtenerPersonasConCitas();
			return result.Result;
		}
	}
}
