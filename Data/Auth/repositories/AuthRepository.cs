using ic_tienda_bussines.Auth.models;
using ic_tienda_bussines.Auth.repositories;
using ic_tienda_bussines.Auth.services;

namespace ic_tienda_data.Auth.repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IRolService _rol;
        private readonly IAppUserService _user;
        private readonly IAuthenticationService _authentication;
        public AuthRepository(
            IRolService rol,
            IAppUserService user,
            IAuthenticationService authentication
            ) 
        { 
            _rol = rol;
            _user = user;
            _authentication = authentication;
        }


        public IRolService rolService { get => _rol; }
        public IAppUserService userService { get => _user; }

        public bool HasPermission(int user_id, int rol_id)
        {
            throw new NotImplementedException();
        }

        public bool HasPermissionByName(int user_id, string rol_name)
        {
            throw new NotImplementedException();
        }

        public LoginResponse Login(string email, string password)
        {
            throw new NotImplementedException();
            // return _authentication.Login(email, password);
        }

        public string RefreshToken(string token)
        {
            throw new NotImplementedException();
            // return _authentication.RefreshToken(token);
        }

        public void Register(AppUserRegister data)
        {
            _authentication.Register(data);
        }
    }
}
