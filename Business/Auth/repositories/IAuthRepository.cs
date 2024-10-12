using Bussines.Auth.models;
using Bussines.Auth.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Auth.repositories
{
    public interface IAuthRepository
    {
        public IRolService rolService { get; }
        public IAppUserService userService { get; }

        public LoginResponse Login(string email, string password);
        public string RefreshToken(string token);
        public bool HasPermission(int user_id, int rol_id);
        public bool HasPermissionByName(int user_id, string rol_name);

        public void Register(AppUserRegister body);
    }
}
