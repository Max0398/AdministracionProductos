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
            try
            {
                if (cbxCargaProductoInactivo.Checked)
                {
                    dgvProductos.DataSource = nProducto.listadoProductosInactivos();
                    dgvProductos.Columns["Eliminar"].Visible = false;
                }
                else
                {
                    dgvProductos.DataSource = nProducto.listadoProductos();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show("No se Pudo Obtener los datos.", $"Errror {err.Message}",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmRegistroProducto fRegistroProducto = new FrmRegistroProducto();
            fRegistroProducto.FormClosed += (s, args) => listarProductos();
            fRegistroProducto.ShowDialog();
            
        }

        private void cbxCargaProductoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            listarProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                bool estado = Convert.ToBoolean(dgvProductos.CurrentRow.Cells["Estado"].Value);
                FrmRegistroProducto fProductoEditar = new FrmRegistroProducto();
                fProductoEditar.editar = true;
                fProductoEditar.txtIdProducto.Text = dgvProductos.CurrentRow.Cells["ProductoID"].Value.ToString();
                fProductoEditar.txtCodigo.Text = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                fProductoEditar.txtExistencias.Text = dgvProductos.CurrentRow.Cells["Existencia"].Value.ToString();
                fProductoEditar.cbxEstado.SelectedItem = estado ? "Activo" : "Inactivo"; 
                fProductoEditar.txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                fProductoEditar.txtProveedor.Text = dgvProductos.CurrentRow.Cells["Proveedor"].Value.ToString();
                fProductoEditar.ShowDialog();
                listarProductos();
            }
            else if (dgvProductos.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int eliminar = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoID"].Value.ToString());
                nProducto.elimacionLogicaProducto(eliminar);
                MessageBox.Show("Eliminado Correctamente","Operacion Exitosa",MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarProductos();
            }
        }
    }
}
