using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PruebaTecnicaMedVision.Models
{

	public class MotivoCita
	{
		[Key]
		public int IdMotivo { get; set; }
		public string Descripcion { get; set; }
		[JsonIgnore]
		public ICollection<Cita> Citas { get; set; }
	}
}
