
namespace EjemploABM
{
    partial class FormAdministracion
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
            this.panel_contenedor_adm = new System.Windows.Forms.Panel();
            this.panel_contenedor_btn = new System.Windows.Forms.Panel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.cmbSucursal = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.panel_contenedor_adm.SuspendLayout();
            this.panel_contenedor_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor_adm
            // 
            this.panel_contenedor_adm.Controls.Add(this.cmbSucursal);
            this.panel_contenedor_adm.Controls.Add(this.txtEmail);
            this.panel_contenedor_adm.Controls.Add(this.panel_contenedor_btn);
            this.panel_contenedor_adm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_adm.Location = new System.Drawing.Point(3, 64);
            this.panel_contenedor_adm.Name = "panel_contenedor_adm";
            this.panel_contenedor_adm.Size = new System.Drawing.Size(586, 217);
            this.panel_contenedor_adm.TabIndex = 0;
            // 
            // panel_contenedor_btn
            // 
            this.panel_contenedor_btn.Controls.Add(this.btnAgregar);
            this.panel_contenedor_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_contenedor_btn.Location = new System.Drawing.Point(0, 168);
            this.panel_contenedor_btn.Name = "panel_contenedor_btn";
            this.panel_contenedor_btn.Size = new System.Drawing.Size(586, 49);
            this.panel_contenedor_btn.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(197, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(214, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Administracion";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.AutoResize = false;
            this.cmbSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSucursal.Depth = 0;
            this.cmbSucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSucursal.DropDownHeight = 174;
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 121;
            this.cmbSucursal.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.IntegralHeight = false;
            this.cmbSucursal.ItemHeight = 43;
            this.cmbSucursal.Location = new System.Drawing.Point(3, 88);
            this.cmbSucursal.MaxDropDownItems = 4;
            this.cmbSucursal.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(304, 49);
            this.cmbSucursal.StartIndex = 0;
            this.cmbSucursal.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(3, 16);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 50);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.Text = "Ingrese Email Administrador/Vendedor";
            this.txtEmail.TrailingIcon = null;
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 284);
            this.Controls.Add(this.panel_contenedor_adm);
            this.Name = "FormAdministracion";
            this.Text = "Alta Administracion / Vendedor";
            this.Load += new System.EventHandler(this.FormAdministracion_Load);
            this.panel_contenedor_adm.ResumeLayout(false);
            this.panel_contenedor_btn.ResumeLayout(false);
            this.panel_contenedor_btn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor_adm;
        private System.Windows.Forms.Panel panel_contenedor_btn;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialComboBox cmbSucursal;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
    }
}