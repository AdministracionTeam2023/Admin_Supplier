using System;

namespace AdminSuppliers.Core
{
    public class Producto
    {
        private int _IdProvedor;
        public Producto()
        {

        }
        public Producto(int id, string descripcion, double precio, DateTime fechaAdquisicion, DateTime fechaGarantia,string provedor)
        {
            this.id = id;
            Descripcion = descripcion;
            Precio = precio;
            FechaAdquisicion = fechaAdquisicion;
            FechaGarantia = fechaGarantia;
            Provedor = provedor;
        }

        public int id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaGarantia { get; set; }
        public String Provedor { get; set; }
       
    }
}
