using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class CitaController : ControllerBase
	{
        ICitaService _citaService;
        public CitaController(ICitaService citaService)
        {
			_citaService = citaService;

		}
		[HttpGet]
		public async Task<IActionResult> ObtenerCitasPorFecha(DateTime date) 
		{
			var res = await _citaService.ObtenerCitasPorFecha(date);
			return Ok(res);
		}
		[HttpPut]
		public async Task<IActionResult> ActualizarCitaPorIdCita(Cita cita)
		{
			await _citaService.ActualizarCitaPorIdCita(cita);
			return Ok();
		}
    }
}
