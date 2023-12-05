using AdminSupplier.Persistence;
using AdminSuppliers.Core;
using AdminSuppliers.Presenter;

namespace ProyectoVenta.Formularios.Incidentes
{
    public partial class frmIncidentes : Form
    {
        private List<Incidencias> _Incidencias = new List<Incidencias>();
        private List<Tecnico> _Tecnicos = new List<Tecnico>();

        private List<ReportInisidencia> _ReportInisidencia = new List<ReportInisidencia>();
        private List<Producto> _ReportDataSource = new List<Producto>();
        public frmIncidentes()
        {
            InitializeComponent();
        }

        public void LoadIncidencias()
        {
            _Incidencias.Clear();
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<Incidencias>(nameof(Incidencias));
                    while (result.Read())
                    {
                        _Incidencias.Add(new Incidencias(
                                            id: (int)result.GetValue(0),
                                            fechaSolicitud: (DateTime)result.GetValue(1),
                                            fechaSolucion: (DateTime)result.GetValue(2),
                                            estado: (string)result.GetValue(3),
                                            detalle: (string)result.GetValue(4)));
                    }
                }
                dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvdata.AutoGenerateColumns = true;
                dgvdata.DataSource = _Incidencias;
                dgvdata.Refresh();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LoadTecnicos()
        {
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<Tecnico>(nameof(Tecnico));
                    while (result.Read())
                    {
                        _Tecnicos.Add(new Tecnico(
                                            id: (int)result.GetValue(0),
                                            apellido: (string)result.GetValue(1),
                                            nombre: (string)result.GetValue(2),
                                            telefono: (string)result.GetValue(3),
                                            email: (string)result.GetValue(4),
                                            provedor: (string)result.GetValue(5)
                                            ));
                    }
                }
                cmbTecnico.DataSource = _Tecnicos.Select(x => x.id + ": " + x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarIncidente_Load(object sender, EventArgs e)
        {
            LoadIncidencias();
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            dgvdata.DataSource = null;
            dgvdata.Refresh();
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            dgvdata.DataSource = null;
            _Incidencias.Add(new Incidencias(id: _Incidencias.Count + 1,
                                        fechaSolicitud: DateTime.Now,
                                        fechaSolucion: fechaSolucionPicker.Value,
                                        estado: txtEstado.Text,
                                        detalle: txtDescripcion.Text
                                        ));
            dgvdata.DataSource = _Incidencias;
        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            if (dgvdata.SelectedRows.Count > 0)
            {
                var incidente = dgvdata.SelectedRows[0].Index;
                _Incidencias.RemoveAt(incidente);
                dgvdata.DataSource = null;
                dgvdata.DataSource = _Incidencias;
                dgvdata.Refresh();
                //persistir dataBase
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnborrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            LoadIncidencias();
            dataGridView1.Refresh();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvdata.DataSource = null;
            string result = cbobuscar.Text;
            switch (result)
            {
                case "Fecha de Solicitud":
                    _Incidencias = _Incidencias.Where(x => dtpInicio.Value < x.FechaSolicitud &&
                                                        x.FechaSolicitud < dtpFin.Value
                                                      ).ToList();
                    break;
                case "Fecha de Solucion":
                    _Incidencias = _Incidencias.Where(x => x.FechaSolucion >= dtpInicio.Value && x.FechaSolucion <= dtpFin.Value
                                                     ).ToList();
                    break;
                case "Nombre":
                    _Incidencias = _Incidencias.Where(x => x.Detalle.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Estado":
                    _Incidencias = _Incidencias.Where(x => x.Estado.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                default:
                    LoadTecnicos();
                    break;
            }
            dgvdata.DataSource = _Incidencias;
            dgvdata.Refresh();
        }


        //public void GenerarReporte()
        //{
        //    LoadIncidencias();
        //    var report = new ReportViewerProductos(_ReportDataSource);
        //    foreach (ReportInisidencia a in _ReportInisidencia)
        //    {
        //        _ReportDataSource.Add(new Producto() { Descripcion = a.Detalle, Precio = a.Cantidad });
        //    }
        //    report._DataSource = _ReportDataSource;
        //    report.Show();
        //    _ReportDataSource = new List<Producto>();

        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fechaSolucionPicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //GenerarReporte();
        }
    }
}