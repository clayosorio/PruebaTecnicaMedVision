using PruebaTecnicaMedVision.Models;

namespace PruebaTecnicaMedVision.Repositories.IRepositories
{
	public interface ICitaRepository
	{
		Task<List<Cita>> ObtenerCitasPorFecha(DateTime date);
		Task ActualizarCitaPorIdCita(Cita cita);
	}
}
