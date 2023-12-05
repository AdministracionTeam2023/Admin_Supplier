using AdminSupplier.Persistence;
using AdminSuppliers.Core;
using AdminSuppliers.Presenter;

namespace AdminSupplier.Presenter
{
    public partial class FormReports : Form
    {
        private List<Producto> _Productos = new List<Producto>();
        private List<ReportProduct> _ReportProducts = new List<ReportProduct>();
        private List<ReportInisidencia> _ReportInisidencia = new List<ReportInisidencia>();
        public FormReports()
        {
            InitializeComponent();
            Cursor.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void LoadProductos()
        {
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<Producto>(nameof(Producto));

                    while (result.Read())
                    {

                        _Productos.Add(new Producto(
                                            id: (int)result.GetValue(0),
                                            descripcion: (string)result.GetValue(1),
                                            precio: double.Parse(result.GetValue(2).ToString()),
                                            fechaAdquisicion: (DateTime)result.GetValue(3),
                                            fechaGarantia: (DateTime)result.GetValue(4),
                                            provedor: (String)result.GetValue(5)
                                            )
                            );
                    }

                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void LoadIncidencias()
        {
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<ReportInisidencia>(nameof(ReportInisidencia));

                    while (result.Read())
                    {

                        _ReportInisidencia.Add(new ReportInisidencia(
                                            (int)result.GetValue(0),
                                             (string)result.GetValue(1)
                                            )
                            );
                    }

                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public void LoadReporte()
        {
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<ReportProduct>(nameof(ReportProduct));

                    while (result.Read())
                    {

                        _ReportProducts.Add(new ReportProduct(
                                            descripcion: (string)result.GetValue(0),
                                             cantidad: (int)result.GetValue(1)
                                            )
                            );
                    }

                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoadProductos();
            LoadReporte();
            var report = new ReportViewerProductos();
            foreach (ReportProduct a in _ReportProducts)
            {
                _Productos.Add(new Producto() { Descripcion = a.Descripcion, Precio = a.Cantidad });



            }

            report._DataSource = _Productos;
            //report.Productos = _ReportProducts;
            report.Show();
            _Productos = new List<Producto>();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadIncidencias();
            var report = new ReportViewerProductos();
            foreach (ReportInisidencia a in _ReportInisidencia)
            {
                _Productos.Add(new Producto() { Descripcion = a.Detalle, Precio = a.Cantidad });
            }
            report._DataSource = _Productos;
            report.Show();
            _Productos = new List<Producto>();
        }
    }
}