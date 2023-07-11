using Microsoft.EntityFrameworkCore;
using PruebaTecnicaMedVision.Context;
using PruebaTecnicaMedVision.Repositories.IRepositories;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Repositories
{
	public class MotivoCitaRepository : IMotivoCitaRepository
	{
        CitasContext _citasContext;
        public MotivoCitaRepository(CitasContext citasContext)
        {
			_citasContext = citasContext;
		}

		public async Task<int> ObtenerCantidadDeCitasPorIdMotivoCita(int idMotivoCita)
		{
			int cantidadCitas = _citasContext.Citas.Count(c => c.MotivosCita.Any(m => m.IdMotivo == idMotivoCita));
			return cantidadCitas;
		}
    }
}
