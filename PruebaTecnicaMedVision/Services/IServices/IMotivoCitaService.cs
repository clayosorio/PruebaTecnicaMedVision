namespace PruebaTecnicaMedVision.Services.IServices
{
	public interface IMotivoCitaService
	{
		Task<int> ObtenerCantidadDeCitasPorIdMotivoCita(int idMotivoCita);
	}
}
