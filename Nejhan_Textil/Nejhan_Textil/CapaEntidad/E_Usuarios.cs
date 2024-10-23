using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        public int Codigo_us { get; set; }
        public string Login_us { get; set; }   
        public string Password_us { get; set; }
        public string Nombres_us { get; set; }
        public string Cargo_us { get; set; }
        public bool Admin { get; set; }
    }
}
