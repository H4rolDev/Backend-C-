using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Auth.models
{
    public class LoginResponse
    {
        public AppUser user { get; set; }
        public Rol rol { get; set; }
        public string token { get; set; }
    }
}
