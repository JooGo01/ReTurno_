
namespace EjemploABM
{
    partial class FormSucursalEditar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodPos = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDepartamento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtProvincia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPiso = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialTextBox();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.panel_contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Controls.Add(this.panel2);
            this.panel_contenedor.Controls.Add(this.panel3);
            this.panel_contenedor.Controls.Add(this.panel1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(3, 64);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(794, 464);
            this.panel_contenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 50);
            this.panel1.TabIndex = 0;
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
            this.panel3.Location = new System.Drawing.Point(389, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 414);
            this.panel3.TabIndex = 2;
            // 
            // txtCodPos
            // 
            this.txtCodPos.AnimateReadOnly = false;
            this.txtCodPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPos.Depth = 0;
            this.txtCodPos.Font = new System.Drawing.Font("Roboto", 12F);
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
            // txtDepartamento
            // 
            this.txtDepartamento.AnimateReadOnly = false;
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Depth = 0;
            this.txtDepartamento.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.txtProvincia.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.txtPiso.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.txtCiudad.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.txtAltura.Font = new System.Drawing.Font("Roboto", 12F);
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
            this.txtCalle.Font = new System.Drawing.Font("Roboto", 12F);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.txtRazonSocial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(-35, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 414);
            this.panel2.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(38, 66);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(345, 50);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.Text = "Ingrese telefono";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AnimateReadOnly = false;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRazonSocial.LeadingIcon = null;
            this.txtRazonSocial.Location = new System.Drawing.Point(38, 10);
            this.txtRazonSocial.MaxLength = 50;
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRazonSocial.Multiline = false;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(345, 50);
            this.txtRazonSocial.TabIndex = 10;
            this.txtRazonSocial.Text = "Ingrese razon social";
            this.txtRazonSocial.TrailingIcon = null;
            this.txtRazonSocial.WordWrap = false;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(309, 6);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(158, 36);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar Sucursal";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormSucursalEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.panel_contenedor);
            this.Name = "FormSucursalEditar";
            this.Text = "Editar Sucursal";
            this.Load += new System.EventHandler(this.FormSucursalEditar_Load);
            this.panel_contenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtRazonSocial;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialTextBox txtCodPos;
        private MaterialSkin.Controls.MaterialTextBox txtDepartamento;
        private MaterialSkin.Controls.MaterialTextBox txtProvincia;
        private MaterialSkin.Controls.MaterialTextBox txtPiso;
        private MaterialSkin.Controls.MaterialTextBox txtCiudad;
        private MaterialSkin.Controls.MaterialTextBox txtAltura;
        private MaterialSkin.Controls.MaterialTextBox txtCalle;
        private MaterialSkin.Controls.MaterialButton btnEditar;
    }
}