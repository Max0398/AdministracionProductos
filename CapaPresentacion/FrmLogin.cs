using CapaEntidades;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        NUsuario nUsuario = new NUsuario(); 
        Usuario usuario = new Usuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            //Validara  Existencia de usuario
            //desde el procedimiento almacenado se devuelve un valor booleano para confirmar existencia del mismo
            if (nUsuario.validarUsuario(usuario, contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                this.Hide();
                limpiar();
                FrmProductos frmProductos = new FrmProductos();
                frmProductos.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        //abrira formulario para registro de nuevo usuario
        private void lblRegistrar_Click(object sender, System.EventArgs e)
        {
            FrmRegistroUsuario frmRegistro = new FrmRegistroUsuario();
            this.Hide();
            frmRegistro.ShowDialog();
            this.Show();
            
        }
        public void limpiar()
        {
            txtContrasenia.Text=string.Empty;
            txtUsuario.Text=string.Empty;
        }
    }
}
