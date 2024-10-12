using Bussines.Auth.models;

namespace Bussines.Auth.services
{
    public interface IAuthorizationService
    {
       public bool HasPermission(int user_id, int rol_id);
        public bool HasPermissionByName(int user_id, string rol_name);
    }
}