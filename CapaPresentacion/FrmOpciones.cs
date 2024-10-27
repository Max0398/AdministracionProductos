using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmOpciones : Form
    {
        NOpciones nOpciones = new NOpciones();
        Opcion opcion = new Opcion();
        public FrmOpciones()
        {
            InitializeComponent();
            cambioColumnas();
            listarOpciones();
        }
        public void cambioColumnas()
        {
            dgvOpciones.Columns[0].Width= 50;
        }

        public void listarOpciones()
        {
            dgvOpciones.DataSource=nOpciones.listadoOpciones();
        }

        private void dgvOpciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOpciones.Rows[e.RowIndex].Cells["Editar"].Selected)
                {

                    bool estado = Convert.ToBoolean(dgvOpciones.CurrentRow.Cells["Estado"].Value);
                    FrmRegistroOpciones fOpcionesEditar = new FrmRegistroOpciones(0);
                    fOpcionesEditar.editar = true;
                    fOpcionesEditar.txtOpcionId.Text = dgvOpciones.CurrentRow.Cells["OpcionID"].Value.ToString();
                    fOpcionesEditar.cbxEstadoOpcion.SelectedItem = estado ? "Activo" : "Inactivo";
                    fOpcionesEditar.txtNombreOpcion.Text = dgvOpciones.CurrentRow.Cells["NombreOpcion"].Value.ToString();
                    fOpcionesEditar.ShowDialog();
                    listarOpciones();

                }

            }
            catch (Exception)
            {

                return;
            }

        }
    }
}
