namespace Vista
{
    partial class ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.ClientesdataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaNacimientodatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Enabled = false;
            this.Cancelarbutton.Location = new System.Drawing.Point(503, 334);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 37;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(403, 334);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 36;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Enabled = false;
            this.Guardarbutton.Location = new System.Drawing.Point(302, 334);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 35;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(206, 334);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 34;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(115, 334);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 33;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(159, 301);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 30;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Esta Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha De Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Correo:";
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Enabled = false;
            this.CorreotextBox.Location = new System.Drawing.Point(159, 167);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(233, 22);
            this.CorreotextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Teléfono:";
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Enabled = false;
            this.TelefonotextBox.Location = new System.Drawing.Point(159, 133);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(233, 22);
            this.TelefonotextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(160, 100);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(233, 22);
            this.NombretextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Identidad:";
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.Enabled = false;
            this.IdentidadtextBox.Location = new System.Drawing.Point(160, 63);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(233, 22);
            this.IdentidadtextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Dirección:";
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Enabled = false;
            this.DirecciontextBox.Location = new System.Drawing.Point(159, 209);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(233, 22);
            this.DirecciontextBox.TabIndex = 38;
            // 
            // ClientesdataGridView
            // 
            this.ClientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesdataGridView.Location = new System.Drawing.Point(1, 372);
            this.ClientesdataGridView.Name = "ClientesdataGridView";
            this.ClientesdataGridView.Size = new System.Drawing.Size(690, 189);
            this.ClientesdataGridView.TabIndex = 41;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FechaNacimientodatedateTimePicker
            // 
            this.FechaNacimientodatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientodatedateTimePicker.Location = new System.Drawing.Point(160, 251);
            this.FechaNacimientodatedateTimePicker.Name = "FechaNacimientodatedateTimePicker";
            this.FechaNacimientodatedateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.FechaNacimientodatedateTimePicker.TabIndex = 42;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 562);
            this.Controls.Add(this.FechaNacimientodatedateTimePicker);
            this.Controls.Add(this.ClientesdataGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefonotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdentidadtextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.CheckBox EstaActivocheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CorreotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.DataGridView ClientesdataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker FechaNacimientodatedateTimePicker;
    }
}