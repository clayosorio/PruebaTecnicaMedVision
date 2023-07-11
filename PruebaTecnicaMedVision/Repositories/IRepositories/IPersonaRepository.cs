using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Models.Response;

namespace PruebaTecnicaMedVision.Repositories.IRepositories
{
	public interface IPersonaRepository
	{
		Task<TokenResponse> Login(string nombreUsuario, string contraseña);
		Task AgregarPersona(Persona persona);
		Task<List<Persona>> ObtenerPersonasConCitas();
	}
}
