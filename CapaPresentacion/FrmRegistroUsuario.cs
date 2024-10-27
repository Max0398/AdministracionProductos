using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

        //funcionalidad Registro usuario
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Contrasenia = txtContrasenia.Text;

            try
            {
                // Validar campos que no esten vacios
                if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrEmpty(txtContrasenia.Text))
                {
                    MessageBox.Show("Hay Campos Vacios", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar el correo
                if (!ValidarEmail(txtCorreo.Text))
                {
                    MessageBox.Show("Formato incorrecto en el campo correo: xxxx@xxxx.com", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                usuario.Correo = txtCorreo.Text;

                // Validar el teléfono
                if (!ValidarTelefono(txtTelefono.Text))
                {
                    MessageBox.Show("Formato incorrecto en el campo Telefono: xxxx-xxxx", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                usuario.Telefono = txtTelefono.Text;

                // Verificar si el usuario ya existe
                if (nUsuario.verificarExisteUsuario(txtNombreUsuario.Text))
                {
                    txtNombreUsuario.Text = "";
                    MessageBox.Show("Ya Existe Ese Usuario", "Ingrese Otro Nombre de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nUsuario.registroUsuario(usuario);
                MessageBox.Show("Registro Exitoso", "Accion Completada con Exitos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            catch (Exception err)
            {

                MessageBox.Show($"Error al Registrar {err}","Verficar Informacion",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        //Validacion correo
        private bool ValidarEmail(string email)
        {
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }
        //Validacion Telefono
        private bool ValidarTelefono(string telefono)
        {
            string patronTelefono = @"^\d{4}-\d{4}$";
            return Regex.IsMatch(telefono, patronTelefono);
        }

       
    }
}
