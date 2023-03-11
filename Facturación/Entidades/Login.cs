namespace Entidades
{
    public class Login
    {
        //Agregar propiedades
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }


        public Login()
        {
        }

        public Login(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;

        }


    }
}
