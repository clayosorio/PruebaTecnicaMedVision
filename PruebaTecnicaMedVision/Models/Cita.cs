using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace PruebaTecnicaMedVision.Models
{
	public class Cita
	{
		[Key]
		public int IdCita { get; set; }
		[DataType(DataType.Date)]
		public DateTime FechaCita { get; set; }

		[JsonIgnore]
		public TimeSpan HoraCitaTimeSpan { get; set; }

		[NotMapped]
		public string HoraCita
		{
			get => HoraCitaTimeSpan.ToString("hh\\:mm");
			set => HoraCitaTimeSpan = TimeSpan.Parse(value);
		}
		public string Lugar { get; set; }
		public int IdMotivoCita { get; set; }
		public int IdPersona { get; set; }
		[JsonIgnore]
		public Persona? Persona { get; set; }
		[JsonIgnore]
		public ICollection<MotivoCita>? MotivosCita { get; set; }
	}
}
