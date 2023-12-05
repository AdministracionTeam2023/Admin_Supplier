using AdminSupplier.Persistence;
using AdminSuppliers.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace AdminSupplier.Presenter
{
    public partial class FormSupplierQualify : Form
    {
        private List<Proveedor> _Proveedores = new List<Proveedor>();
        private Proveedor _Proveedor;
        public FormSupplierQualify()
        {
            InitializeComponent();
            LoadProovedores();
        }

        public void LoadProovedores()
        {
            try
            {
                using (var db = new DBContext())
                {
                    var result = db.GetAll<Proveedor>(nameof(Proveedor));

                    while (result.Read())
                    {
                        _Proveedores.Add(new Proveedor(
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

                dgvProvedores.DataSource = _Proveedores;
                dgvProvedores.Refresh();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private void GetElement()
        {
            var index = dgvProvedores.SelectedRows[0].Index;
            _Proveedor = _Proveedores.ElementAt(index);
            lblCalification.Text = _Proveedor != null ? _Proveedor.Califiacion.ToString() : "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProvedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvProvedores.SelectedRows.Count > 0)
            {
                GetElement();
            }
        }

        private void btnStar1_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "1";
        }

        private void star2_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "2";
        }

        private void star3_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "3";
        }

        private void star4_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "4";
        }

        private void star5_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "5";
        }

        private void star6_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "6";
        }

        private void star7_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "7";
        }

        private void star8_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "8";

        }

        private void star9_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "9";

        }

        private void star10_Click(object sender, EventArgs e)
        {
            lblCalificacionNueva.Text = "10";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                GetElement();
                db.Calificar<Tecnico>(_Proveedor.id
                                      , long.Parse(lblCalificacionNueva.Text));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
