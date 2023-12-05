using AdminSupplier.Presenter;
using AdminSuppliers.Presenter.Forms;
using ProyectoVenta.Formularios.Incidentes;
using ProyectoVenta.Formularios.Proveedores;
using ProyectoVenta.Formularios.Tecnicos;
using System.Windows.Forms;

namespace ProyectoVenta.Formularios
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new frmLogin());
        }
        private void ShowControls(bool show = true)
        {
            pContainer.Visible = show;
        }
        public void ConfigurateChildForm(Form form)
        {
            form.MdiParent = this;
            form.FormClosed += (s, args) => ShowControls();
            form.Show();
        }

        private void btnIncidentes_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new frmIncidentes());
        }



        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new frmTecnicos());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new frmProveedores());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new FormReports());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new frmProveedores());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new FormProductos());
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ShowControls(false);
            ConfigurateChildForm(new FormSupplierQualify());
        }
    }
}
