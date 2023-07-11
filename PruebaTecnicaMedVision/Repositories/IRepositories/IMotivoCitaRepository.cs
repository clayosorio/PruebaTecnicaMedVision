namespace PruebaTecnicaMedVision.Repositories.IRepositories
{
	public interface IMotivoCitaRepository
	{
		Task<int> ObtenerCantidadDeCitasPorIdMotivoCita(int idMotivoCita);
	}
}
