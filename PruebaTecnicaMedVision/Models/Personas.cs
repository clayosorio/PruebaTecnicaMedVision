using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PruebaTecnicaMedVision.Models
{
	public class Persona
	{
		[Key]
		public int? IdPersona { get; set; }
		public string NombreUsuario { get; set; }
		public string Contraseña { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		[JsonIgnore]
		public ICollection<Cita>? Citas { get; set; }
	}
}
