using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSuppliers.Core
{
    public  class ReportInisidencia
    {
        public ReportInisidencia(int cantidad,  string detalle)
        {
            Cantidad = cantidad;
            Detalle = detalle;
        }
        public int Cantidad { get; set; }
        public string Detalle { get; set; }
        //public int FechaSolicitud { get 
        //    {
        //         CultureInfo cultura = CultureInfo.CurrentCulture;
        //        Calendar calendario = cultura.Calendar;
        //        return calendario.GetWeekOfYear(FechaInicio, cultura.DateTimeFormat.CalendarWeekRule, cultura.DateTimeFormat.FirstDayOfWeek);
        //    }
        //    set 
        //    {
        //        FechaSolicitud = value;
        //    }

        //}
        //public int FechaSolucion { get 
        //    {
        //        CultureInfo cultura = CultureInfo.CurrentCulture;
        //        Calendar calendario = cultura.Calendar;
        //        return calendario.GetWeekOfYear(FechaFin, cultura.DateTimeFormat.CalendarWeekRule, cultura.DateTimeFormat.FirstDayOfWeek);

        //    }
        //    set
        //    {
        //        FechaSolucion = value;
        //    }
        //}

    }
}
