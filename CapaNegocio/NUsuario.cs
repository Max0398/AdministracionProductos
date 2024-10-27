using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{

    public class NUsuario
    {
        DUsuario dUsuario = new DUsuario();

        public bool validarUsuario(string usuario,string contrasenia)
        {
            return dUsuario.validarUsuario(usuario, contrasenia);
        }
        public void registroUsuario(Usuario usuario)
        {
            dUsuario.registroUsuario(usuario);
        }

        public bool verificarExisteUsuario(string usuario)
        {
            return dUsuario.verificarUsuario(usuario);
        }
    }
}
