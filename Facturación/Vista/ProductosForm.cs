﻿using System.Windows.Forms;

namespace Vista
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        string operecion;

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
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
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
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
