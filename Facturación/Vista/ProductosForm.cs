using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        string operecion;
        Producto producto;
        ProductoDB productoDB = new ProductoDB();
        DataTable dt = new DataTable();

        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            operecion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            DescripciontextBox.Enabled = true;
            ExistenciatextBox.Enabled = true;
            PreciotextBox.Enabled = true;
            AdjuntarImagenbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            Nuevobutton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            DescripciontextBox.Clear();
            ExistenciatextBox.Clear();
            PreciotextBox.Clear();
            EstaActivocheckBox.Checked = false;
            ImagenpictureBox.Image = null;
            producto = null;
        }

        private void DesabilitarControles()
        {
            CodigotextBox.Enabled = false;
            DescripciontextBox.Enabled = false;
            ExistenciatextBox.Enabled = false;
            PreciotextBox.Enabled = false;
            AdjuntarImagenbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Nuevobutton.Enabled = true;
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DesabilitarControles();
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            operecion = "Modificar";

            if (ProductosdataGridView.SelectedRows.Count > 0)
            {
                CodigotextBox.Text = ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripciontextBox.Text = ProductosdataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                ExistenciatextBox.Text = ProductosdataGridView.CurrentRow.Cells["Existencia"].Value.ToString();
                PreciotextBox.Text = ProductosdataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(ProductosdataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = productoDB.DevolverFoto(ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                if (img.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    ImagenpictureBox.Image = System.Drawing.Image.FromStream(ms);
                }

                HabilitarControles();
                CodigotextBox.ReadOnly = true;


            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            producto = new Producto();
            producto.Codigo = CodigotextBox.Text;
            producto.Descripcion = DescripciontextBox.Text;
            producto.Precio = Convert.ToDecimal(PreciotextBox.Text);
            producto.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
            producto.EstaActivo = EstaActivocheckBox.Checked;

            if (ImagenpictureBox.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ImagenpictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                producto.Foto = ms.GetBuffer();

            }

            if (operecion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox.Text))
                {
                    errorProvider1.SetError(CodigotextBox, "Ingrese un código");
                    CodigotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(DescripciontextBox.Text))
                {
                    errorProvider1.SetError(DescripciontextBox, "Ingrese lunadescripción");
                    DescripciontextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(ExistenciatextBox.Text))
                {
                    errorProvider1.SetError(ExistenciatextBox, "Ingrese una existencia");
                    ExistenciatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(PreciotextBox.Text))
                {
                    errorProvider1.SetError(PreciotextBox, "Ingrese un  precio");
                    PreciotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();



                bool inserto = productoDB.Insertar(producto);
                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro guardado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (operecion == "Modicar")
            {
                bool modifico = productoDB.Editar(producto);
                if (modifico)
                {
                    CodigotextBox.ReadOnly = false;
                    DesabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("Registro actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo actualizarel registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ExistenciatextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PreciotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void AdjuntarImagenbutton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ImagenpictureBox.Image = Image.FromFile(dialog.FileName);

            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerProductos();
        }

        private void TraerProductos()
        {
            ProductosdataGridView.DataSource = productoDB.DevolverProducto();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ProductosdataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar el registro", "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = productoDB.Eliminar(ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        TraerProductos();
                        MessageBox.Show("Registro eliminado");
                    }
                }

            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro ");
            }
        }
    }
}

