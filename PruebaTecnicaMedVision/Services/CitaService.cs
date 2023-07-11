using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Repositories;
using PruebaTecnicaMedVision.Repositories.IRepositories;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Services
{
	public class CitaService: ICitaService
	{
		ICitaRepository _citaRepository;
        public CitaService(ICitaRepository citaRepository)
        {
			_citaRepository = citaRepository;

		}
        public async Task<List<Cita>> ObtenerCitasPorFecha(DateTime date)
		{
			var res = _citaRepository.ObtenerCitasPorFecha(date);
			return res.Result;
		}
		public async Task ActualizarCitaPorIdCita(Cita cita)
		{
			await _citaRepository.ActualizarCitaPorIdCita(cita);
		}
	}
}
