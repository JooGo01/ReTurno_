
namespace EjemploABM
{
    partial class FormCliente
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
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_contenedor_boton = new System.Windows.Forms.Panel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.panel_direccion = new System.Windows.Forms.Panel();
            this.panel_contenedor_usuario = new System.Windows.Forms.Panel();
            this.panel_contenedor_cliente = new System.Windows.Forms.Panel();
            this.cmbTipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDNI = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContrasenia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodPos = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDepartamento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProvincia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPiso = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbRubro = new MaterialSkin.Controls.MaterialComboBox();
            this.panel_contenedor.SuspendLayout();
            this.panel_contenedor_boton.SuspendLayout();
            this.panel_direccion.SuspendLayout();
            this.panel_contenedor_usuario.SuspendLayout();
            this.panel_contenedor_cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Controls.Add(this.panel_contenedor_cliente);
            this.panel_contenedor.Controls.Add(this.panel_contenedor_usuario);
            this.panel_contenedor.Controls.Add(this.panel_direccion);
            this.panel_contenedor.Controls.Add(this.panel_contenedor_boton);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(3, 64);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(920, 545);
            this.panel_contenedor.TabIndex = 0;
            // 
            // panel_contenedor_boton
            // 
            this.panel_contenedor_boton.Controls.Add(this.btnAgregar);
            this.panel_contenedor_boton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contenedor_boton.Location = new System.Drawing.Point(0, 500);
            this.panel_contenedor_boton.Name = "panel_contenedor_boton";
            this.panel_contenedor_boton.Size = new System.Drawing.Size(920, 45);
            this.panel_contenedor_boton.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(394, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(129, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Crear cliente";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // panel_direccion
            // 
            this.panel_direccion.Controls.Add(this.txtCodPos);
            this.panel_direccion.Controls.Add(this.txtDepartamento);
            this.panel_direccion.Controls.Add(this.txtProvincia);
            this.panel_direccion.Controls.Add(this.txtPiso);
            this.panel_direccion.Controls.Add(this.txtCiudad);
            this.panel_direccion.Controls.Add(this.txtAltura);
            this.panel_direccion.Controls.Add(this.txtCalle);
            this.panel_direccion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_direccion.Location = new System.Drawing.Point(614, 0);
            this.panel_direccion.Name = "panel_direccion";
            this.panel_direccion.Size = new System.Drawing.Size(306, 500);
            this.panel_direccion.TabIndex = 1;
            // 
            // panel_contenedor_usuario
            // 
            this.panel_contenedor_usuario.Controls.Add(this.cmbTipoUsuario);
            this.panel_contenedor_usuario.Controls.Add(this.txtDNI);
            this.panel_contenedor_usuario.Controls.Add(this.txtContrasenia);
            this.panel_contenedor_usuario.Controls.Add(this.txtTelefono);
            this.panel_contenedor_usuario.Controls.Add(this.txtEmail);
            this.panel_contenedor_usuario.Controls.Add(this.txtApellido);
            this.panel_contenedor_usuario.Controls.Add(this.txtNombre);
            this.panel_contenedor_usuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_contenedor_usuario.Location = new System.Drawing.Point(308, 0);
            this.panel_contenedor_usuario.Name = "panel_contenedor_usuario";
            this.panel_contenedor_usuario.Size = new System.Drawing.Size(306, 500);
            this.panel_contenedor_usuario.TabIndex = 2;
            // 
            // panel_contenedor_cliente
            // 
            this.panel_contenedor_cliente.Controls.Add(this.cmbRubro);
            this.panel_contenedor_cliente.Controls.Add(this.txtRazonSocial);
            this.panel_contenedor_cliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_contenedor_cliente.Location = new System.Drawing.Point(2, 0);
            this.panel_contenedor_cliente.Name = "panel_contenedor_cliente";
            this.panel_contenedor_cliente.Size = new System.Drawing.Size(306, 500);
            this.panel_contenedor_cliente.TabIndex = 3;
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
            this.cmbTipoUsuario.Location = new System.Drawing.Point(6, 387);
            this.cmbTipoUsuario.MaxDropDownItems = 4;
            this.cmbTipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(279, 49);
            this.cmbTipoUsuario.StartIndex = 0;
            this.cmbTipoUsuario.TabIndex = 27;
            // 
            // txtDNI
            // 
            this.txtDNI.AnimateReadOnly = false;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Depth = 0;
            this.txtDNI.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDNI.LeadingIcon = null;
            this.txtDNI.Location = new System.Drawing.Point(6, 163);
            this.txtDNI.MaxLength = 50;
            this.txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(279, 50);
            this.txtDNI.TabIndex = 26;
            this.txtDNI.Text = "Ingrese DNI";
            this.txtDNI.TrailingIcon = null;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.AnimateReadOnly = false;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Depth = 0;
            this.txtContrasenia.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtContrasenia.LeadingIcon = null;
            this.txtContrasenia.Location = new System.Drawing.Point(6, 331);
            this.txtContrasenia.MaxLength = 50;
            this.txtContrasenia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasenia.Multiline = false;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(279, 50);
            this.txtContrasenia.TabIndex = 25;
            this.txtContrasenia.Text = "Ingrese Contraseña";
            this.txtContrasenia.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(6, 219);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(279, 50);
            this.txtTelefono.TabIndex = 24;
            this.txtTelefono.Text = "Ingrese Telefono";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(6, 275);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 50);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Text = "Ingrese Email";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtApellido
            // 
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(6, 107);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(279, 50);
            this.txtApellido.TabIndex = 22;
            this.txtApellido.Text = "Ingrese Apellido";
            this.txtApellido.TrailingIcon = null;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(6, 51);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 50);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Text = "Ingrese Nombre";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.WordWrap = false;
            // 
            // txtCodPos
            // 
            this.txtCodPos.AnimateReadOnly = false;
            this.txtCodPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPos.Depth = 0;
            this.txtCodPos.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCodPos.LeadingIcon = null;
            this.txtCodPos.Location = new System.Drawing.Point(8, 275);
            this.txtCodPos.MaxLength = 50;
            this.txtCodPos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodPos.Multiline = false;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.Size = new System.Drawing.Size(287, 50);
            this.txtCodPos.TabIndex = 21;
            this.txtCodPos.Text = "Ingrese Codigo Postal";
            this.txtCodPos.TrailingIcon = null;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.AnimateReadOnly = false;
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Depth = 0;
            this.txtDepartamento.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDepartamento.LeadingIcon = null;
            this.txtDepartamento.Location = new System.Drawing.Point(8, 163);
            this.txtDepartamento.MaxLength = 50;
            this.txtDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepartamento.Multiline = false;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(287, 50);
            this.txtDepartamento.TabIndex = 20;
            this.txtDepartamento.Text = "Ingrese departamento";
            this.txtDepartamento.TrailingIcon = null;
            // 
            // txtProvincia
            // 
            this.txtProvincia.AnimateReadOnly = false;
            this.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvincia.Depth = 0;
            this.txtProvincia.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtProvincia.LeadingIcon = null;
            this.txtProvincia.Location = new System.Drawing.Point(6, 386);
            this.txtProvincia.MaxLength = 50;
            this.txtProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProvincia.Multiline = false;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(289, 50);
            this.txtProvincia.TabIndex = 19;
            this.txtProvincia.Text = "Ingrese provincia";
            this.txtProvincia.TrailingIcon = null;
            // 
            // txtPiso
            // 
            this.txtPiso.AnimateReadOnly = false;
            this.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPiso.Depth = 0;
            this.txtPiso.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPiso.LeadingIcon = null;
            this.txtPiso.Location = new System.Drawing.Point(8, 219);
            this.txtPiso.MaxLength = 50;
            this.txtPiso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPiso.Multiline = false;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(287, 50);
            this.txtPiso.TabIndex = 18;
            this.txtPiso.Text = "Ingrese piso";
            this.txtPiso.TrailingIcon = null;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(6, 330);
            this.txtCiudad.MaxLength = 50;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Multiline = false;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(289, 50);
            this.txtCiudad.TabIndex = 17;
            this.txtCiudad.Text = "Ingrese ciudad";
            this.txtCiudad.TrailingIcon = null;
            // 
            // txtAltura
            // 
            this.txtAltura.AnimateReadOnly = false;
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(6, 107);
            this.txtAltura.MaxLength = 50;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Multiline = false;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(289, 50);
            this.txtAltura.TabIndex = 16;
            this.txtAltura.Text = "Ingrese altura";
            this.txtAltura.TrailingIcon = null;
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(6, 51);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Multiline = false;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(289, 50);
            this.txtCalle.TabIndex = 15;
            this.txtCalle.Text = "Ingrese calle";
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.WordWrap = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AnimateReadOnly = false;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRazonSocial.LeadingIcon = null;
            this.txtRazonSocial.Location = new System.Drawing.Point(3, 51);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRazonSocial.Multiline = false;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(279, 50);
            this.txtRazonSocial.TabIndex = 22;
            this.txtRazonSocial.Text = "Ingrese Razon Social";
            this.txtRazonSocial.TrailingIcon = null;
            this.txtRazonSocial.WordWrap = false;
            // 
            // cmbRubro
            // 
            this.cmbRubro.AutoResize = false;
            this.cmbRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRubro.Depth = 0;
            this.cmbRubro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRubro.DropDownHeight = 174;
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.DropDownWidth = 121;
            this.cmbRubro.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.IntegralHeight = false;
            this.cmbRubro.ItemHeight = 43;
            this.cmbRubro.Location = new System.Drawing.Point(3, 108);
            this.cmbRubro.MaxDropDownItems = 4;
            this.cmbRubro.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(279, 49);
            this.cmbRubro.StartIndex = 0;
            this.cmbRubro.TabIndex = 28;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 612);
            this.Controls.Add(this.panel_contenedor);
            this.Name = "FormCliente";
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor_boton.ResumeLayout(false);
            this.panel_contenedor_boton.PerformLayout();
            this.panel_direccion.ResumeLayout(false);
            this.panel_contenedor_usuario.ResumeLayout(false);
            this.panel_contenedor_cliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel_contenedor_boton;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private System.Windows.Forms.Panel panel_contenedor_cliente;
        private System.Windows.Forms.Panel panel_contenedor_usuario;
        private System.Windows.Forms.Panel panel_direccion;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtDNI;
        private MaterialSkin.Controls.MaterialTextBox txtContrasenia;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtApellido;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtCodPos;
        private MaterialSkin.Controls.MaterialTextBox txtDepartamento;
        private MaterialSkin.Controls.MaterialTextBox txtProvincia;
        private MaterialSkin.Controls.MaterialTextBox txtPiso;
        private MaterialSkin.Controls.MaterialTextBox txtCiudad;
        private MaterialSkin.Controls.MaterialTextBox txtAltura;
        private MaterialSkin.Controls.MaterialTextBox txtCalle;
        private MaterialSkin.Controls.MaterialComboBox cmbRubro;
        private MaterialSkin.Controls.MaterialTextBox txtRazonSocial;
    }
}