using AdminSuppliers.Core;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSuppliers.Presenter
{
    public partial class FormReportIncidencias : Form
    {
        public FormReportIncidencias()
        {
            InitializeComponent();
        }

        public List<Producto> lista { get; set; }
        private void ReportViewerIncidencias_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportEmbeddedResource = "AdminSuppliers.Presenter.rptProductos.rdlc";

            DataSet1 ds = new DataSet1();


            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lista));
            reportViewer1.RefreshReport();


            //reportViewer1.LocalReport.ReportEmbeddedResource = "AdminSuppliers.Presenter.rptIncidencias.rdlc";

            //DataSet2 ds = new DataSet2();

            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", lista));
            //reportViewer1.RefreshReport();

        }

    }
}
