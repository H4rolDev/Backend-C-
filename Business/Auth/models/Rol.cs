using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Auth.models
{
    public class RolBody {
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator Rol(RolBody rb) {
            if (rb == null) return null;
            return new Rol {
                Id = 0,
                Name = rb.Name,
                Description = rb.Description
            };
        }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
