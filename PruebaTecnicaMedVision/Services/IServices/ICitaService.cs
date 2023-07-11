using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Models;

namespace PruebaTecnicaMedVision.Services.IServices
{
	public interface ICitaService
	{
		Task<List<Cita>> ObtenerCitasPorFecha(DateTime date);
		Task ActualizarCitaPorIdCita(Cita cita);
	}
}
