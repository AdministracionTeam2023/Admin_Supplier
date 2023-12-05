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
using System.Windows.Forms;

namespace AdminSuppliers.Presenter.Forms
{
    public partial class FormProductos : Form
    {
        private List<Producto> _Producto= new List<Producto>();
        public FormProductos()
        {
            InitializeComponent();
            LoadProductos();
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
                      
                        _Producto.Add(new Producto(
                                            id: (int)result.GetValue(0),
                                            descripcion: (string)result.GetValue(1),
                                            precio: double.Parse( result.GetValue(2).ToString()),
                                            fechaAdquisicion: (DateTime)result.GetValue(3),
                                            fechaGarantia: (DateTime)result.GetValue(4),
                                            provedor: (String)result.GetValue(5)
                                            ));
                    }

                }
                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvProductos.AutoGenerateColumns = true;
                dgvProductos.DataSource = _Producto;
                dgvProductos.Refresh();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
