using AdminSuppliers.Core;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace AdminSuppliers.Presenter
{
    public partial class ReportViewerProductos : Form
    {
        public ReportViewerProductos()
        {
            InitializeComponent();
        }
        public ReportViewerProductos(List<Producto> dataSource)
        {
            InitializeComponent();
            _DataSource = dataSource;
            
        }
        public List<Producto> _DataSource { get; set; }
        private void ReportViewerProductos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "AdminSuppliers.Presenter.rptProductos.rdlc";
            DataSet1 ds = new DataSet1();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _DataSource));
            reportViewer1.RefreshReport();

        }

       
    }
}
