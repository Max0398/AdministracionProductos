using CapaEntidades;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        Producto producto = new Producto();
        NProducto nProducto = new NProducto();
        NOpciones nOpciones = new NOpciones();
        Opcion opcion = new Opcion();

        public FrmProductos()
        {
            InitializeComponent();
            listarProductos();
            ocultarColumnas();
            dgvProductos.ClearSelection();
            dgvProductos.CurrentCell = null;
            txtBusqueda.Text = "Ingrese Codigo o Nombre del Producto";
            txtBusqueda.ForeColor = Color.Gray;
        }

        public void listarProductos()
        {
            // se listara por defecto todos los productos 
            // de lo contrario solo los seleccionados activos o inactivos
            try
            {
                if (cbxCargaProductoInactivo.Checked) //Listara solo inactivos
                {
                    dgvProductos.DataSource = nProducto.listadoProductosInactivos();
                    dgvProductos.Columns["Eliminar"].Visible = false;
                }
                else if (cbxCargarProductoActivo.Checked) //listara solo activos
                {
                    dgvProductos.DataSource=nProducto.listadoProductosActivos();
                    dgvProductos.Columns["Eliminar"].Visible = true;
                }
                else
                {
                    dgvProductos.DataSource = nProducto.listadoProductos();
                    dgvProductos.Columns["Eliminar"].Visible = false;

                }

            }
            catch (Exception err)
            {

                MessageBox.Show("No se Pudo Obtener los datos.", $"Errror {err.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvProductos.Columns[3].Width = 80;
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //aplicara formato para resltar el estado de existencias dependiendo la cantidad
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Existencia")
            {
                try
                {
                    //para cuando sea menos de 10
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
            try
            {
                // Verifica indice para evitar errores de seleccion
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                // Identificar las columnas por índice para evitar que cuando se seleccione una celda se habra otra mas
                int editarColumnIndex = dgvProductos.Columns["Editar"].Index;
                int eliminarColumnIndex = dgvProductos.Columns["Eliminar"].Index;
                int opcionesColumnIndex = dgvProductos.Columns["Opciones"].Index;
                int agregarOpcionColumnIndex = dgvProductos.Columns["AgregarOpcion"].Index;

                // Funcionalidad para Editar
                if (e.ColumnIndex == editarColumnIndex)
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
                // Funcionalidad para Eliminar
                else if (e.ColumnIndex == eliminarColumnIndex)
                {
                    // Muestra un mensaje de confirmación antes de proceder a elimina
                    var confirmarResultado = MessageBox.Show("¿Estás seguro que desea eliminar este producto?",
                                                         "Confirmar Eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);
                    
                    if (confirmarResultado == DialogResult.Yes)
                    {
                        int eliminar = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoID"].Value.ToString());
                        nProducto.elimacionLogicaProducto(eliminar);
                        MessageBox.Show("Eliminado Correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarProductos();
                    }
                }
                // Funcionalidad para Opciones
                else if (e.ColumnIndex == opcionesColumnIndex)
                {
                    int productoId = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoID"].Value);
                    var opciones = nOpciones.productoOpciones(productoId);

                    if (opciones != null && opciones.Rows.Count > 0)
                    {
                        dgvOpciones.DataSource = opciones;
                        dgvOpciones.Columns["EditarActual"].Visible = true;
                        dgvOpciones.Columns["OpcionID"].Visible = false;
                        dgvOpciones.Columns["ProductoID"].Visible = false;
                    }
                    else
                    {
                        dgvOpciones.Columns["EditarActual"].Visible = false;
                        dgvOpciones.DataSource = null;
                    }
                    dgvOpciones.Refresh();
                }
                // Funcionalidad para Agregar Opción
                else if (e.ColumnIndex == agregarOpcionColumnIndex)
                {
                    int productoId = Convert.ToInt32(dgvProductos.CurrentRow.Cells["ProductoID"].Value.ToString());
                    FrmRegistroOpciones fRegistroOpciones = new FrmRegistroOpciones(productoId);
                    fRegistroOpciones.ShowDialog();
                    listarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //para mostrar un texto como placeholder en el textbox de busqueda
        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Ingrese Codigo o Nombre del Producto")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            // Si el TextBox está vacío, mostrar el placeholder
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Ingrese Codigo o Nombre del Producto";
                txtBusqueda.ForeColor = Color.Gray;
                listarProductos();
            }
        }

        //cargara el texto que se escribay buscara elementos que coincidad como codigo o nombre
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            var buscar = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(buscar) && buscar != "Ingrese Codigo o Nombre del Producto")
            {
                // Solo busca si hay texto que no es el placeholder
                dgvProductos.DataSource = nProducto.filtroNombreCodigo(buscar);
            }
            else
            {
                // Si el TextBox está vacío o tiene el placeholder, muestra todos los productos
                listarProductos();
            }
        }

        //Funcionalidad para editar las opciones disponibles desde el datagrip
        private void dgvOpciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOpciones.Rows[e.RowIndex].Cells["EditarActual"].Selected)
                {
                    int ProductoId = Convert.ToInt32(dgvOpciones.CurrentRow.Cells["ProductoID"].Value);
                    bool estado = Convert.ToBoolean(dgvOpciones.CurrentRow.Cells["Estado"].Value);
                    FrmRegistroOpciones fOpcionesEditar = new FrmRegistroOpciones(0);
                    fOpcionesEditar.editar = true;
                    fOpcionesEditar.txtOpcionId.Text = dgvOpciones.CurrentRow.Cells["OpcionID"].Value.ToString();
                    fOpcionesEditar.cbxEstadoOpcion.SelectedItem = estado ? "Activo" : "Inactivo";
                    fOpcionesEditar.txtNombreOpcion.Text = dgvOpciones.CurrentRow.Cells["NombreOpcion"].Value.ToString();
                    fOpcionesEditar.ShowDialog();
                    dgvOpciones.DataSource = nOpciones.productoOpciones(ProductoId);
                    
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        //Mostrara todas las opcines Disponibles de todos los productos
        private void btnListadoOpciones_Click(object sender, EventArgs e)
        {
            FrmOpciones fOpciones = new FrmOpciones();
            fOpciones.ShowDialog();
        }

        private void cbxCargarProductoActivo_CheckedChanged(object sender, EventArgs e)
        {
            listarProductos();
        }

        
    }
}
