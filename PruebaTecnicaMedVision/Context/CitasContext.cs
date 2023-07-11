using Microsoft.EntityFrameworkCore;
using PruebaTecnicaMedVision.Models;

namespace PruebaTecnicaMedVision.Context
{
	public class CitasContext : DbContext
	{
        public CitasContext() { }
        public DbSet<Persona> Personas { get; set; }
		public DbSet<Cita> Citas { get; set; }
		public DbSet<MotivoCita> MotivosCita { get; set; }

		public CitasContext(DbContextOptions<CitasContext> options) : base(options) { }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Persona>().HasData(
			   new Persona { IdPersona = 1, NombreUsuario = "sebas", Contraseña = "123", Nombre = "Sebastian", Apellido = "Guerrero", Edad = 25 },
			   new Persona { IdPersona = 2, NombreUsuario = "dani", Contraseña = "123",  Nombre = "Daniel", Apellido = "Obando", Edad = 25 }
		   );

			modelBuilder.Entity<Cita>().HasData(
				new Cita { IdCita = 1, FechaCita = DateTime.Now.AddDays(1), HoraCita = "10:00", Lugar = "Clinica nuestra", IdMotivoCita = 1, IdPersona = 1 },
				new Cita { IdCita = 2, FechaCita = DateTime.Now.AddDays(2), HoraCita = "09:00", Lugar = "Clinica nuestra", IdMotivoCita = 2, IdPersona = 2 }
			);

			modelBuilder.Entity<MotivoCita>().HasData(
				new MotivoCita { IdMotivo = 1, Descripcion = "Cita Ortopedia" },
				new MotivoCita { IdMotivo = 2, Descripcion = "Cita Anesteciologo" }
			);
		}
	}
}
