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

            if (nUsuario.validarUsuario(usuario, contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                this.Hide();
                FrmProductos frmProductos = new FrmProductos();
                frmProductos.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void lblRegistrar_Click(object sender, System.EventArgs e)
        {
            FrmRegistroUsuario frmRegistro = new FrmRegistroUsuario();
            this.Hide();
            frmRegistro.ShowDialog();
            this.Show();
        }
    }
}
