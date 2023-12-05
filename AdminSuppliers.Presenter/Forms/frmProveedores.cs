using AdminSupplier.Persistence;
using AdminSupplier.Presenter;
using AdminSuppliers.Core;

namespace ProyectoVenta.Formularios.Proveedores
{
    public partial class frmProveedores : Form
    {
        private List<Proveedor> _Proveedor = new List<Proveedor>();

        public frmProveedores()
        {
            InitializeComponent();
        }

        public void LoadProovedores()
        {
            _Proveedor.Clear();
            dgvProvedores.DataSource = null;
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<Proveedor>(nameof(Proveedor));

                    while (result.Read())
                    {
                        _Proveedor.Add(new Proveedor(
                                            id: (int)result.GetValue(0),
                                            cuit: (string)result.GetValue(1)
                                            , razonSocial: (string)result.GetValue(2)
                                            , descripcionEmpresa: (string)result.GetValue(2)
                                            , telefono: (string)result.GetValue(3)
                                            , califiacion: (double)result.GetValue(5))
                                            );
                    }

                }
                dgvProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvProvedores.AutoGenerateColumns = true;
                dgvProvedores.DataSource = _Proveedor;
                dgvProvedores.Refresh();
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            LoadProovedores();
        }

        private void btnguadar_Click(object sender, EventArgs e)
            => _Proveedor.Add(new Proveedor(cuit: txtcuit.Text
                                            , razonSocial: txtrazonsocial.Text
                                            , descripcionEmpresa: txtEmpresa.Text
                                            , telefono: txtTelefono.Text
                                           ));
        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            btnbuscar_Click(sender,e);
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            dgvProvedores.DataSource = null;
            switch (cbobuscar.Text)
            {
                case "Apellido":
                    _Proveedor = _Proveedor.Where(x => x.Cuit.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Empresa":
                    _Proveedor = _Proveedor.Where(x => x.Empresa.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Cuit":
                    _Proveedor = _Proveedor.Where(x => x.Cuit.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Telefono":
                    _Proveedor = _Proveedor.Where(x => x.Telefono.ToLower().Equals(txtbuscar.Text.ToLower())).ToList();
                    break;
                case "Calificación":
                    _Proveedor = _Proveedor.Where(x => x.Califiacion == double.Parse(txtbuscar.Text)).ToList();
                    break;
                default:
                    LoadProovedores();
                    break;
            }
            dgvProvedores.DataSource = _Proveedor;
            dgvProvedores.Refresh();
        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            LoadProovedores();
            dgvProvedores.Refresh();
        }


    }
}
