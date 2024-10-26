using CapaEntidades;
using CapaNegocio;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        Producto producto = new Producto();
        NProducto nProducto = new NProducto();

        public FrmProductos()
        {
            InitializeComponent();
            listarProductos();
            ocultarColumnas();
        }

       public void listarProductos()
        {
            dgvProductos.DataSource= nProducto.listadoProductos();
        }

        public void ocultarColumnas()
        {
            dgvProductos.Columns["ProductoID"].Visible = false;
            dgvProductos.Columns["Editar"].DisplayIndex = 8;
            dgvProductos.Columns["Eliminar"].DisplayIndex = 8;
            dgvProductos.Columns["Opciones"].DisplayIndex = 8;
            dgvProductos.Columns[0].Width = 50;
            dgvProductos.Columns[1].Width = 50;
            dgvProductos.Columns[2].Width = 60;
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Existencia")
            {
                try
                {
                    if (Convert.ToInt32(e.Value) < 10)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Green;
                    }
                }
                catch
                {
                    return;
                }

            }

        }

        
    }
}
