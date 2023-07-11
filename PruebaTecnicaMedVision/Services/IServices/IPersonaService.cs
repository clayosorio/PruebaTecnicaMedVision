using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Models.Response;

namespace PruebaTecnicaMedVision.Services.IServices
{
	public interface IPersonaService
	{

		Task<TokenResponse> Login(string nombreUsuario, string contraseña);
		Task AgregarPersona(Persona persona);
		Task<List<Persona>> ObtenerPersonasConCitas();
	}
}
