using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class MotivoCitaController : ControllerBase
	{
		IMotivoCitaService _motivoCitaService;
        public MotivoCitaController(IMotivoCitaService motivoCitaService)
        {
			_motivoCitaService = motivoCitaService;
		}
		[HttpGet]
		public async Task<IActionResult> ObtenerCantidadDeCitasPorIdMotivoCita(int idMotivoCita)
		{
			int res = await _motivoCitaService.ObtenerCantidadDeCitasPorIdMotivoCita(idMotivoCita);
			return Ok(res);
		}
	}
}
