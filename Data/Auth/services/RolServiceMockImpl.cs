using ic_tienda_bussines.Auth.models;
using ic_tienda_bussines.Auth.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ic_tienda_data.Auth.services
{
    public class RolServiceMockImpl : IRolService
    {
        private readonly List<Rol> roles = new List<Rol>
        {
            new Rol {Id =1, Name = "Admin", Description = "admin" },
            new Rol {Id =2, Name = "Ventas", Description = "ventas" },
            new Rol {Id =3, Name = "Caja", Description = "caja" },
        };
        public Rol Create(Rol entity)
        {
            return new Rol { Id = 4, Name = "Otro", Description = "caja" };
        }

        public void Delete(int id)
        {
            return;
        }

        public List<Rol> GetAll()
        {
            return roles;
        }

        public Rol? GetById(int id)
        {
            return roles.FirstOrDefault(r => r.Id == id);
        }

        public void Update(int id, Rol entity)
        {
            return;
        }
    }
}
