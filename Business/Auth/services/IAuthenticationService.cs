using Bussines.Auth.models;

namespace Bussines.Auth.services
{
    public interface IAuthenticationService
    {
        public void Register(AppUserRegister body);
    }
}
