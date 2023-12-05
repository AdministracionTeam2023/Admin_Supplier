using System;
using System.Collections.Generic;

namespace AdminSuppliers.Core
{
    public class Pedido
    {
        public int id { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estado { get; set; }
        public List<Producto> MyProperty { get; set; }
    }
}
