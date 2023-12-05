using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSuppliers.Core
{
    public class ReportProduct
    {
        public ReportProduct()
        {
            
        }
        public ReportProduct(string descripcion,int cantidad)
        {
            Cantidad=cantidad;
            Descripcion=descripcion;    
        }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
