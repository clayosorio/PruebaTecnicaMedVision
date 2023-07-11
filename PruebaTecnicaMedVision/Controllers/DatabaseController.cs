using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaMedVision.Context;

namespace PruebaTecnicaMedVision.Controllers
{
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class DatabaseController : ControllerBase
	{
		CitasContext _citasContext;
        public DatabaseController(CitasContext citasContext)
        {
			_citasContext = citasContext;

		}
        [HttpGet]
		public IActionResult CreateDatabase()
		{
			_citasContext.Database.EnsureCreated();
			return Ok();
		}
	}
}
