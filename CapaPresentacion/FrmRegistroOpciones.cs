using CapaEntidades;
using CapaEntidades;
using CapaEntidades;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistroOpciones : Form
    {
        public int idProducto;
        public bool editar = false;
        NOpciones nOpcion = new NOpciones();
        Opcion opcion = new Opcion();
        public FrmRegistroOpciones(int idProducto)
        {
            InitializeComponent();
            this.idProducto = idProducto;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {
                try
                {
                    opcion.ProductoId = this.idProducto;
                    opcion.NombreOpcion = txtNombreOpcion.Text;
                    if (cbxEstadoOpcion.Text == "Activo")
                    {
                        opcion.Estado = true;
                    }
                    else if (cbxEstadoOpcion.Text == "Inactivo")
                    {
                        opcion.Estado = false;
                    }
                    nOpcion.registrarOpcion(opcion);
                    MessageBox.Show("Se registro el Producto", "Registro Esxitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {

                    MessageBox.Show("Error Al registrar la Opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            if (editar)
            {
                try
                {
                    opcion.NombreOpcion = txtNombreOpcion.Text;
                    opcion.OpcionId = Convert.ToInt32(txtOpcionId.Text);
                    if (cbxEstadoOpcion.Text == "Activo")
                    {
                        opcion.Estado = true;
                    }
                    else if (cbxEstadoOpcion.Text == "Inactivo")
                    {
                        opcion.Estado = false;
                    }
                    nOpcion.editarOpcion(opcion);
                    MessageBox.Show("Se Edito Correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();


                }
                catch (Exception err)
                {

                    MessageBox.Show($"Error al Editar {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Limpiar()
        {
            txtNombreOpcion.Text = "";
            txtOpcionId.Text = "";
            cbxEstadoOpcion.SelectedValue = "Activo";
        }
    }
}
