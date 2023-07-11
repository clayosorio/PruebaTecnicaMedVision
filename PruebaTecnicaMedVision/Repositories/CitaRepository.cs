using Microsoft.EntityFrameworkCore;
using PruebaTecnicaMedVision.Context;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Repositories.IRepositories;

namespace PruebaTecnicaMedVision.Repositories
{
	public class CitaRepository : ICitaRepository
	{
		CitasContext _citasContext;
        public CitaRepository(CitasContext citasContext)
        {
			_citasContext = citasContext;

		}
        public async Task<List<Cita>> ObtenerCitasPorFecha(DateTime date)
		{
			var res = _citasContext.Citas.Include(p => p.MotivosCita).Where(p => p.FechaCita.Date == date.Date);
			return res.ToList();
		}

		public async Task ActualizarCitaPorIdCita(Cita cita)
		{
			var targetCita = _citasContext.Citas.Where(p => p.IdCita == cita.IdCita).FirstOrDefault();

			if (targetCita == null)
			{
				throw new Exception("La cita que intenta actualizar no se encuentra en la base de datos");
			}

			targetCita.FechaCita = cita.FechaCita;
			targetCita.HoraCita = cita.HoraCita;
			targetCita.Lugar = cita.Lugar;

			await _citasContext.SaveChangesAsync();
		}


	}
}
