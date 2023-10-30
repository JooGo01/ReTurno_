namespace EjemploABM
{
    partial class FormUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDepartamento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProvincia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPiso = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContrasenia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCodPos = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 473);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 72);
            this.panel2.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(355, 9);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(153, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCodPos);
            this.panel3.Controls.Add(this.txtDepartamento);
            this.panel3.Controls.Add(this.txtProvincia);
            this.panel3.Controls.Add(this.txtPiso);
            this.panel3.Controls.Add(this.txtCiudad);
            this.panel3.Controls.Add(this.txtAltura);
            this.panel3.Controls.Add(this.txtCalle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(424, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 401);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbTipoUsuario);
            this.panel4.Controls.Add(this.txtDNI);
            this.panel4.Controls.Add(this.txtContrasenia);
            this.panel4.Controls.Add(this.txtTelefono);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.txtApellido);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 401);
            this.panel4.TabIndex = 2;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AnimateReadOnly = false;
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Depth = 0;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepartamento.LeadingIcon = null;
            this.txtDepartamento.Location = new System.Drawing.Point(25, 122);
            this.txtDepartamento.MaxLength = 50;
            this.txtDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepartamento.Multiline = false;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(343, 50);
            this.txtDepartamento.TabIndex = 13;
            this.txtDepartamento.Text = "Ingrese departamento";
            this.txtDepartamento.TrailingIcon = null;
            // 
            // txtProvincia
            // 
            this.txtProvincia.AnimateReadOnly = false;
            this.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvincia.Depth = 0;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProvincia.LeadingIcon = null;
            this.txtProvincia.Location = new System.Drawing.Point(25, 345);
            this.txtProvincia.MaxLength = 50;
            this.txtProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProvincia.Multiline = false;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(343, 50);
            this.txtProvincia.TabIndex = 12;
            this.txtProvincia.Text = "Ingrese provincia";
            this.txtProvincia.TrailingIcon = null;
            // 
            // txtPiso
            // 
            this.txtPiso.AnimateReadOnly = false;
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPiso.Depth = 0;
            this.txtPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPiso.LeadingIcon = null;
            this.txtPiso.Location = new System.Drawing.Point(25, 178);
            this.txtPiso.MaxLength = 50;
            this.txtPiso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPiso.Multiline = false;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(343, 50);
            this.txtPiso.TabIndex = 11;
            this.txtPiso.Text = "Ingrese piso";
            this.txtPiso.TrailingIcon = null;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(23, 289);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(345, 50);
            this.txtCiudad.TabIndex = 10;
            this.txtCiudad.Text = "Ingrese ciudad";
            this.txtCiudad.TrailingIcon = null;
            // 
            // txtAltura
            // 
            this.txtAltura.AnimateReadOnly = false;
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(23, 66);
            this.txtAltura.MaxLength = 50;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(345, 50);
            this.txtAltura.TabIndex = 9;
            this.txtAltura.Text = "Ingrese altura";
            this.txtAltura.TrailingIcon = null;
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(23, 10);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(345, 50);
            this.txtCalle.TabIndex = 8;
            this.txtCalle.Text = "Ingrese calle";
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.WordWrap = false;
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(3, 122);
            this.txtDNI.MaxLength = 50;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(343, 50);
            this.txtDNI.TabIndex = 19;
            this.txtDNI.Text = "Ingrese DNI";
            this.txtDNI.TrailingIcon = null;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AnimateReadOnly = false;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContrasenia.LeadingIcon = null;
            this.txtContrasenia.Location = new System.Drawing.Point(3, 290);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(343, 50);
            this.txtContrasenia.TabIndex = 18;
            this.txtContrasenia.Text = "Ingrese Contraseña";
            this.txtContrasenia.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(3, 178);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(343, 50);
            this.txtTelefono.TabIndex = 17;
            this.txtTelefono.Text = "Ingrese Telefono";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(3, 234);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 50);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Text = "Ingrese Email";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(3, 66);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(345, 50);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.Text = "Ingrese Apellido";
            this.txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(1, 10);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(345, 50);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.Text = "Ingrese Nombre";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.WordWrap = false;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.AutoResize = false;
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoUsuario.Depth = 0;
            this.cmbTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoUsuario.DropDownHeight = 174;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.DropDownWidth = 121;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.IntegralHeight = false;
            this.cmbTipoUsuario.ItemHeight = 43;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(3, 346);
            this.cmbTipoUsuario.MaxDropDownItems = 4;
            this.cmbTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(343, 49);
            this.cmbTipoUsuario.StartIndex = 0;
            this.cmbTipoUsuario.TabIndex = 20;
            // 
            // txtCodPos
            // 
            this.txtCodPos.AnimateReadOnly = false;
            this.txtCodPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPos.Depth = 0;
            this.txtCodPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodPos.LeadingIcon = null;
            this.txtCodPos.Location = new System.Drawing.Point(25, 234);
            this.txtCodPos.MaxLength = 50;
            this.txtCodPos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodPos.Multiline = false;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.Size = new System.Drawing.Size(343, 50);
            this.txtCodPos.TabIndex = 14;
            this.txtCodPos.Text = "Ingrese Codigo Postal";
            this.txtCodPos.TrailingIcon = null;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 540);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox txtDNI;
        private MaterialSkin.Controls.MaterialTextBox txtContrasenia;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtDepartamento;
        private MaterialSkin.Controls.MaterialTextBox txtProvincia;
        private MaterialSkin.Controls.MaterialTextBox txtPiso;
        private MaterialSkin.Controls.MaterialTextBox txtCiudad;
        private MaterialSkin.Controls.MaterialTextBox txtAltura;
        private MaterialSkin.Controls.MaterialTextBox txtCalle;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtCodPos;
    }
}