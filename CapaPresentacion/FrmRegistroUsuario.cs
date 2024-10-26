using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistroUsuario : Form
    {
        Usuario usuario = new Usuario();
        NUsuario nUsuario = new NUsuario();
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            usuario.NombreUsuario=txtNombreUsuario.Text;
            usuario.Nombre=txtNombre.Text;
            usuario.Apellido=txtApellido.Text;
            usuario.Contrasenia=txtContrasenia.Text;
            if (ValidarEmail(txtCorreo.Text)){ 
                usuario.Correo=txtCorreo.Text;
            }
            else
            {
               
                MessageBox.Show("Formato incorrecto en el campo correo: xxxx@xxxx.com", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            if (ValidarTelefono(txtTelefono.Text))
            {
                usuario.Telefono = txtTelefono.Text;
            }
            else
            {
                MessageBox.Show("Formato incorrecto en el campo Telefono: xxxx-xxxx","Error de Formato",MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            nUsuario.registroUsuario(usuario);
            MessageBox.Show("Registro Exitoso","Accion Completada con Exitos!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            
            
        }


        //Validacion correo y Telefono
        private bool ValidarEmail(string email)
        {
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }

        private bool ValidarTelefono(string telefono)
        {
            string patronTelefono = @"^\d{4}-\d{4}$";
            return Regex.IsMatch(telefono, patronTelefono);
        }
        

    }
}
