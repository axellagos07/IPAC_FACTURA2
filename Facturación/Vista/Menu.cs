using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariostoolStripButton_Click(object sender, System.EventArgs e)
        {
            UsuariosForm useForm = new UsuariosForm();
            useForm.MdiParent = this;
            useForm.Show();
        }

        private void ProductostoolStripButton_Click(object sender, System.EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        private void VentastoolStripButton_Click(object sender, System.EventArgs e)
        {

        }

        private void ClientestoolStripButton_Click(object sender, System.EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }
    }
}
