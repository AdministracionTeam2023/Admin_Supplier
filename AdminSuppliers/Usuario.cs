using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSuppliers.Core
{
    public class Usuario
    {
        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = contraseña;
        }

        public string Nombre { get; set; }
        public string Contraseña { get; set; }
    }

}
