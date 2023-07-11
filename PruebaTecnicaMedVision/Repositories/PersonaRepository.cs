using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PruebaTecnicaMedVision.Context;
using PruebaTecnicaMedVision.Models;
using PruebaTecnicaMedVision.Models.Response;
using PruebaTecnicaMedVision.Repositories.IRepositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PruebaTecnicaMedVision.Repositories
{
    public class PersonaRepository : IPersonaRepository
	{
		CitasContext _citasContext;
		private readonly string _authToken;
		public PersonaRepository(CitasContext citasContext, IConfiguration config)
        {
			_citasContext = citasContext;
			_authToken = config.GetSection("settings").GetSection("secretkey").ToString();

		}
        public async Task<TokenResponse> Login(string nombreUsuario, string contraseña)
		{
			var persona = _citasContext.Personas.Where(p => p.NombreUsuario == nombreUsuario && p.Contraseña == contraseña).FirstOrDefault();

			if (persona == null)
			{
				throw new Exception("Credenciales incorrectas, por favor intente de nuevo");
			}

			var keyBytes = Encoding.ASCII.GetBytes(_authToken);
			var claims = new ClaimsIdentity();

			claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, nombreUsuario, contraseña));

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[] {
					new Claim("Nombre", persona.Nombre.ToString()),
					new Claim("Apellido", persona.Apellido.ToString()),
					new Claim("Edad", persona.Edad.ToString())
				}),
				Expires = DateTime.UtcNow.AddMinutes(60),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature),
			};

			var tokenHandler = new JwtSecurityTokenHandler();
			var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

			var tokenCreated = tokenHandler.WriteToken(tokenConfig);

			//await InsertLogLoginTableDB(user, "Login");

			return new TokenResponse
			{
				Succes = true,
				Token = tokenCreated
			};
		}
		[Authorize]
		public async Task AgregarPersona(Persona persona)
		{
			var targetPersona = _citasContext.Personas.Where(p => p.IdPersona == persona.IdPersona).FirstOrDefault();
			
			if (targetPersona != null)
			{
				throw new Exception("La persona que intenta registrar ya se encuentra en la base de datos, por favor intente con un id diferente");
			}

			_citasContext.Personas.Add(persona);
			await _citasContext.SaveChangesAsync();
		}

		public async Task<List<Persona>> ObtenerPersonasConCitas()
		{
			var personasConCitas = _citasContext.Personas.Include(p => p.Citas).ToList();
			return personasConCitas;
		}
	}
}
