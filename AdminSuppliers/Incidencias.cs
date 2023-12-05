using System;

namespace AdminSuppliers.Core
{
    public class Incidencias
    {
        public Incidencias(int id, DateTime fechaSolicitud, DateTime fechaSolucion, string estado, string detalle)
        {
            this.id = id;
            //this.idTecnico = idTecnico;
            FechaSolicitud = fechaSolicitud;
            FechaSolucion = fechaSolucion;
            Estado = estado;
            Detalle = detalle;
            //Tecnico = tecnico;
        }

        public int id { get; set; }
        //public int idTecnico { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaSolucion { get; set; }
        public string Estado { get; set; }
        public string Detalle { get; set; }

        //public Tecnico Tecnico { get; set; }

        //public void AddTecnico(IEnumerable<Tecnico> tecnicos)
        //{
        //    Tecnico= tecnicos.Where(x => x.id == idTecnico)
        //                     .Single();
        //}




    }
}
