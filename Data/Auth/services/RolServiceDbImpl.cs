using ic_tienda_bussines.Auth.models;
using ic_tienda_bussines.Auth.services;
using ic_tienda_data.sources.BaseDeDatos;
using ic_tienda_data.sources.BaseDeDatos.Tables;
using ic_tienda_data.Auth.Transforms;
using ic_tienda_bussines.Errors;

namespace ic_tienda_data.Auth.services
{
    public class RolServiceDbImpl : IRolService
    {
        private readonly IcTiendaDbContext _db;
        public RolServiceDbImpl(IcTiendaDbContext db) {
            _db = db;
        }


        public Rol Create(Rol entity)
        {
            RolTable rolTable = entity.ToTable();
            _db.roles.Add(rolTable);
            int r = _db.SaveChanges();
            if (r == 1)
            {
                entity.Id = rolTable.id;
                return entity;
            }
            else
            {
                throw new MessageExeption("No se pudo insertar roles");
            }
        }

        public void Delete(int id)
        {
            RolTable? rolTable = _db.roles.FirstOrDefault(r => r.id == id && r.estado);
            if (rolTable == null) throw new MessageExeption("No se encontro el rol");
            //_db.roles.Remove(rolTable);
            rolTable.estado = false;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo eliminar roles");
        }

        public List<Rol> GetAll()
        {
            List<Rol> roles = _db.roles
                .Where(r => r.estado)
                .Select<RolTable, Rol>(
                    rt => rt.ToModel()
                )
                .ToList();
            return roles;
        }

        public Rol? GetById(int id)
        {
            RolTable? rol = _db.roles
                .FirstOrDefault(r => r.id == id && r.estado);
            if (rol == null) return null;
            return rol.ToModel();
        }

        public void Update(int id, Rol body)
        {
            RolTable? rol = _db.roles
                .FirstOrDefault(r => r.id == id && r.estado);
            if (rol == null) throw new MessageExeption("No se encontro el rol");
            rol.nombre = body.Name;
            rol.descripcion = body.Description;
            int r = _db.SaveChanges();
            if (r == 1) return;
            else throw new MessageExeption("No se pudo eliminar roles");
        }
    }
}
