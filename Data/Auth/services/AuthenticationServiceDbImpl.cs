using ic_tienda_bussines.Auth.models;
using ic_tienda_bussines.Errors;
using ic_tienda_data.sources.BaseDeDatos;
using ic_tienda_data.sources.BaseDeDatos.Tables;
using ic_tienda_data.Auth.Transforms;
using System.Security.Cryptography;
using System.Text;
using ic_tienda_bussines.Auth.services;

namespace ic_tienda_data.Auth.services
{

    public class AuthenticationServiceDbImpl: IAuthenticationService {
        private readonly IcTiendaDbContext _db;
        public AuthenticationServiceDbImpl(IcTiendaDbContext db) {
            _db = db;
        }

        public LoginResponse Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public string RefreshToken(string token)
        {
            throw new NotImplementedException();
        }

        public void Register(AppUserRegister data)
        {
            if (data.Password != data.RePassword) 
                throw new MessageExeption("las contraseñas deben ser iguales");
            // Validar que correo no exista
            int exist = _db.usuarios.Where(u => u.correo == data.Email).Count();
            if (exist > 0)
                throw new MessageExeption($"El usuario {data.Email} ya existe");
            // crear persona
            PersonaTable person = data.ToPerson();
            _db.personas.Add(person);
            int rp = _db.SaveChanges();
            if (rp <= 0) new MessageExeption("Error al guardar los datos.");
            // crear usuario
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

            UsuarioTable user = new UsuarioTable {
                correo = data.Email,
                id_persona = person.id,
                clave = HashPassword(data.Password, salt),
                salt = Encoding.Default.GetString(salt),
                id_rol = 3,
                estado = true,

            };
            _db.usuarios.Add(user);

            // Guardar
            int r = _db.SaveChanges();
            if (r <= 0) 
                throw new MessageExeption("Error al guardar los datos.");
        }

        private string HashPassword(string password, byte[] salt) {
            int keySize = 64;
            int iterations = 350000;
            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithm,
                keySize);
            return Convert.ToHexString(hash);
        }
    }
}
