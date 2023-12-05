using AdminSupplier.Persistence;
using AdminSuppliers.Core;
using System.Windows.Forms;

namespace ProyectoVenta.Formularios.Tecnicos
{
    public partial class frmTecnicos : Form
    {
        private List<Tecnico> _Tecnicos = new List<Tecnico>();
        private List<Proveedor> _Provedores = new List<Proveedor>();

        public frmTecnicos()
        {
            InitializeComponent();
        }
        public void LoadProvedores()
        {
            _Provedores.Clear();
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<Proveedor>(nameof(Proveedor));

                    while (result.Read())
                    {
                        _Provedores.Add(new Proveedor(
                                            id: (int)result.GetValue(0),
                                            cuit: (string)result.GetValue(1)
                                            , razonSocial: (string)result.GetValue(2)
                                            , descripcionEmpresa: (string)result.GetValue(2)
                                            , telefono: (string)result.GetValue(3)
                                            , califiacion: (double)result.GetValue(5))
                                            );
                    }

                }
                cboProveedor.DataSource = _Provedores.Select(x=>x.Empresa).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void LoadTecnicos()
        {
            _Tecnicos.Clear();
            dgvTecnicos.DataSource = null;
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
                                            provedor: (string)result.GetValue(6)
                                            ));
                    }

                }
                dgvTecnicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvTecnicos.AutoGenerateColumns = true;
                dgvTecnicos.DataSource = _Tecnicos;
                dgvTecnicos.Refresh();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            LoadTecnicos();
            LoadProvedores();
        }


        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgvTecnicos.DataSource = null;
            dgvTecnicos.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvTecnicos.DataSource = null;
            Tecnico tecnico = new Tecnico(id: _Tecnicos.Count + 1,
                                        apellido: txtApellido.Text,
                                        nombre: txtNombre.Text,
                                        telefono: txtTelefono.Text,
                                        email: txtEmail.Text,
                                        provedor: cboProveedor.Text);

            _Tecnicos.Add(tecnico);
            dgvTecnicos.DataSource = _Tecnicos;
            using (DBContext db = new DBContext())
            {
                db.CreateTecnico(tecnico);
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                var tecnico = dgvTecnicos.SelectedRows[0].Index;
                _Tecnicos.RemoveAt(tecnico);
                dgvTecnicos.DataSource = null;
                dgvTecnicos.DataSource = _Tecnicos;
                dgvTecnicos.Refresh();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvTecnicos.DataSource = null;
            switch (cbobuscar.Text)
            {
                case "Apellido":
                    _Tecnicos = _Tecnicos.Where(x => x.Apellido.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Nombre":
                    _Tecnicos = _Tecnicos.Where(x => x.Nombre.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Telefono":
                    _Tecnicos = _Tecnicos.Where(x => x.Telefono.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                default:
                    LoadTecnicos();
                    break;
            }
            dgvTecnicos.DataSource = _Tecnicos;
            dgvTecnicos.Refresh();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            LoadTecnicos();
            dgvTecnicos.Refresh();
        }
    }
}
