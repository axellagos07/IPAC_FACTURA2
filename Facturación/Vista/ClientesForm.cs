using Datos;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;
namespace Vista
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        string operecion;
        Cliente cliente;
        ClienteDB clienteDB = new ClienteDB();
        DataTable dt = new DataTable();

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdentidadtextBox.Focus();
            HabilitarControles();
            operecion = "Nuevo";
        }

        private void HabilitarControles()
        {
            IdentidadtextBox.Enabled = true;
            NombretextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            Guardarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            Nuevobutton.Enabled = false;
        }

        private void LimpiarControles()
        {

            IdentidadtextBox.Clear();
            NombretextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            DirecciontextBox.Clear();
            cliente = null;
        }

        private void DesabilitarControles()
        {
            IdentidadtextBox.Enabled = false;
            NombretextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void Modificarbutton_Click_1(object sender, EventArgs e)
        {
            operecion = "Modificar";

            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                IdentidadtextBox.Text = ClientesdataGridView.CurrentRow.Cells["Identidad"].Value.ToString();
                NombretextBox.Text = ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                TelefonotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                CorreotextBox.Text = ClientesdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                DirecciontextBox.Text = ClientesdataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                //FechaNacimientodateTimePicker.Value = Convert.ToDateTime(ClientesdataGridView.CurrentRow.Cells["FechaNacimiento"]);
                EstaActivocheckBox.Checked = Convert.ToBoolean(ClientesdataGridView.CurrentRow.Cells["EstaActivo"].Value);

                HabilitarControles();
                //IdentidadtextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            cliente = new Cliente();

            if (operecion == "Nuevo")
            {
                if (string.IsNullOrEmpty(IdentidadtextBox.Text))
                {
                    errorProvider1.SetError(IdentidadtextBox, "Ingrese una Identidad");
                    IdentidadtextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(NombretextBox.Text))
                {
                    errorProvider1.SetError(NombretextBox, "Ingrese un Nombre");
                    NombretextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(TelefonotextBox.Text))
                {
                    errorProvider1.SetError(TelefonotextBox, "Ingrese un Telefono");
                    TelefonotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(CorreotextBox.Text))
                {
                    errorProvider1.SetError(CorreotextBox, "Ingrese un  correo");
                    CorreotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(DirecciontextBox.Text))
                {
                    errorProvider1.SetError(DirecciontextBox, "Ingrese una dirección");
                    DirecciontextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                cliente.Identidad = IdentidadtextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                //cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                cliente.EstaActivo = EstaActivocheckBox.Checked;

                bool inserto = clienteDB.Insertar(cliente);
                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    TraerClientes();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (operecion == "Modificar")
            {
                cliente.Identidad = IdentidadtextBox.Text;
                cliente.Nombre = NombretextBox.Text;
                cliente.Telefono = TelefonotextBox.Text;
                cliente.Correo = CorreotextBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                //cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                cliente.EstaActivo = EstaActivocheckBox.Checked;

                bool modifico = clienteDB.Editar(cliente);
                if (modifico)
                {
                    IdentidadtextBox.ReadOnly = false;
                    LimpiarControles();
                    DesabilitarControles();
                    TraerClientes();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo actualizarel registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void TraerClientes()
        {
            ClientesdataGridView.DataSource = clienteDB.DevolverClientes();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = clienteDB.Eliminar(ClientesdataGridView.CurrentRow.Cells["Identidad"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerClientes();
                        MessageBox.Show("Registro eliminado");
                    }
                }

            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro ");
            }
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerClientes();
        }
    }
}
