using PruebaTecnicaMedVision.Repositories.IRepositories;
using PruebaTecnicaMedVision.Services.IServices;

namespace PruebaTecnicaMedVision.Services
{
	public class MotivoCitaService : IMotivoCitaService
	{
        IMotivoCitaRepository _motivoCitaRepository;
        public MotivoCitaService(IMotivoCitaRepository motivoCitaRepository)
        {
			_motivoCitaRepository = motivoCitaRepository;

		}

		public async Task<int> ObtenerCantidadDeCitasPorIdMotivoCita(int idMotivoCita)
		{
			int res = await _motivoCitaRepository.ObtenerCantidadDeCitasPorIdMotivoCita(idMotivoCita);
			return res;
		}

	}
}
