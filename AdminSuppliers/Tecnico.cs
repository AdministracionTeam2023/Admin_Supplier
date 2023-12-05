using System.Reflection;
using System.Xml.Serialization;

namespace AdminSuppliers.Core
{
    [Serializable]
    public class Tecnico //: IEntitty
    {
        public Tecnico(int id, string apellido, string nombre, string telefono, string email, long calificacion)
        {
            this.id = id;
            Apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            //Calificacion = calificacion;
        }
       
        public Tecnico(int id, string apellido, string nombre, string telefono, string email, string provedor)
        {
            this.id = id;
            Apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Provedor=provedor;
            //Calificacion = calificacion;
            //IdIncidencias = idIncidencias;
        }
        public int id { get; set; }
        public string Apellido { get; set; }

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Provedor { get; set; }
        //public long Calificacion { get; set; }
        //public long calificacion_counter { get; set; }
        //public int IdIncidencias{ get; set; }

       


    }
}
