using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un usuario ");
                UsuariotextBox.Clear();
                UsuariotextBox.Focus();
                return;
            }

            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña ");
                ContraseñatextBox.Clear();
                ContraseñatextBox.Focus();
                return;
            }
            errorProvider1.Clear();
        }
    }
}
