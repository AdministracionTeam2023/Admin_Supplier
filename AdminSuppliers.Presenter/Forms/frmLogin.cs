using AdminSupplier.Persistence;
using AdminSuppliers.Core;
using System.Data;

namespace ProyectoVenta.Formularios
{
    public partial class frmLogin : Form
    {

        List<Usuario> _Usuarios = new List<Usuario>();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (_Usuarios.Any(x=>x.Nombre==txtusuario.Text && x.Contraseña==txtclave.Text))
                this.Close();
        }
     

            private void frmLogin_Load(object sender, EventArgs e)
            {
                try
                {
                    using (var db = new DBContext())
                    {
                        var result = db.GetAll<Usuario>(nameof(Usuario));

                        while (result.Read())
                        {
                            _Usuarios.Add(new Usuario((string)result.GetValue(0),
                                                      (string)result.GetValue(1))
                                                     );
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
    }
}
