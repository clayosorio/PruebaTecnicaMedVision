namespace PruebaTecnicaMedVision.Models.Response
{
	public class PersonasCitasResponse
	{
		public int IdPersona { get; set; }
		public string NombreUsuario { get; set; }
		public string Contraseña { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		public int IdCita { get; set; }
		public DateTime FechaCita { get; set; }
		public TimeSpan HoraCita { get; set; }
		public string Lugar { get; set; }
	}
}
