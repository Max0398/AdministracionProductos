using CapaEntidades;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistroProducto : Form
    {

        Producto producto = new Producto();
        NProducto nProducto = new NProducto();
        public bool editar = false;
        private String idProducto;

        public FrmRegistroProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar ==false)
            {
                try
                {
                    producto.Codigo = txtCodigo.Text;
                    producto.Nombre = txtNombre.Text;
                    producto.NombreProveedor = txtProveedor.Text;
                    producto.Existencia = Convert.ToInt32(txtExistencias.Text);
                    if (cbxEstado.Text == "Activo")
                    {
                        producto.Estado = true;
                    }
                    else if (cbxEstado.Text == "Inactivo")
                    {
                        producto.Estado = false;
                    }
                    nProducto.registrarProductos(producto);

                }
                catch (Exception err)
                {

                    MessageBox.Show($"Error al Guardar {err}");
                }

                MessageBox.Show("Se Registro el Producto");
                limpiar();

            
            }
            if (editar)
            {


                try
                {
                    idProducto=txtIdProducto.Text;
                    producto.IdProducto=Convert.ToInt32(idProducto);
                    producto.Codigo = txtCodigo.Text;
                    producto.Nombre = txtNombre.Text;
                    producto.NombreProveedor = txtProveedor.Text;
                    producto.Existencia = Convert.ToInt32(txtExistencias.Text);
                    if (cbxEstado.Text == "Activo")
                    {
                        producto.Estado = true;
                    }
                    else if (cbxEstado.Text == "Inactivo")
                    {
                        producto.Estado = false;
                    }
                    nProducto.editarProducto(producto);
             

                }
                catch (Exception err)
                {

                    MessageBox.Show($"Error al Editar el Producto {err}");
                }

                MessageBox.Show("Se Edito el Producto");
                limpiar();

            }
        }

        public void limpiar()
        {
            txtCodigo.Text=String.Empty;
            txtExistencias.Text=String.Empty;
            txtNombre.Text=String.Empty;
            txtProveedor.Text=String.Empty;
            cbxEstado.Text = "Activo";
        }

        

    }
}
