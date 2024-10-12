using Bussines.Auth.models;
using Data.DataBase.Tables;

namespace Dataata.Auth.Transforms
{
  public static class RegisterExtentions {
    public static Cliente ToPerson(this AppUserRegister body) {
      return new Cliente {
        id = 0,
        RSocial = body.RSocial,
        apellidos = body.LastName,
        tipo_documento = body.DocumentType,
        numero_documento = body.DocumentType,
        telefono = body.LastName,
        estado = true
      };
    }
  }
}