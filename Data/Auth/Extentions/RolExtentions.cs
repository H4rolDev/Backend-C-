using ic_tienda_bussines.Auth.models;
using ic_tienda_data.sources.BaseDeDatos.Tables;

namespace ic_tienda_data.Auth.Transforms
{
  
  public static class RolExtentions {
    public static Rol ToModel(this RolTable rt) {
      return new Rol {
        Id = rt.id,
        Name = rt.nombre,
        Description = rt.descripcion
      };
    }

    public static RolTable ToTable(this Rol r) {
      return new RolTable {
        id = r.Id,
        nombre = r.Name,
        descripcion = r.Description,
        estado = true
      };
    }
  }
}