﻿namespace EjemploABM
{
    partial class FormTurno
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
            this.lblHoraFin = new MaterialSkin.Controls.MaterialLabel();
            this.cbHoraIni = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cbServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSucursal = new MaterialSkin.Controls.MaterialComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.cbSubServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSubServicio);
            this.panel1.Controls.Add(this.lblHoraFin);
            this.panel1.Controls.Add(this.cbHoraIni);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.cbServicio);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.cmbSucursal);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 422);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Depth = 0;
            this.lblHoraFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoraFin.Location = new System.Drawing.Point(144, 297);
            this.lblHoraFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(1, 0);
            this.lblHoraFin.TabIndex = 19;
            // 
            // cbHoraIni
            // 
            this.cbHoraIni.AutoResize = false;
            this.cbHoraIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHoraIni.Depth = 0;
            this.cbHoraIni.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbHoraIni.DropDownHeight = 174;
            this.cbHoraIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraIni.DropDownWidth = 121;
            this.cbHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbHoraIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHoraIni.FormattingEnabled = true;
            this.cbHoraIni.IntegralHeight = false;
            this.cbHoraIni.ItemHeight = 43;
            this.cbHoraIni.Location = new System.Drawing.Point(147, 223);
            this.cbHoraIni.MaxDropDownItems = 4;
            this.cbHoraIni.MouseState = MaterialSkin.MouseState.OUT;
            this.cbHoraIni.Name = "cbHoraIni";
            this.cbHoraIni.Size = new System.Drawing.Size(198, 49);
            this.cbHoraIni.StartIndex = 0;
            this.cbHoraIni.TabIndex = 18;
            this.cbHoraIni.SelectedIndexChanged += new System.EventHandler(this.cbHoraIni_SelectedIndexChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(10, 236);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 17;
            this.materialLabel6.Text = "Hora Inicio:";
            // 
            // cbServicio
            // 
            this.cbServicio.AutoResize = false;
            this.cbServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbServicio.Depth = 0;
            this.cbServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbServicio.DropDownHeight = 174;
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.DropDownWidth = 121;
            this.cbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.IntegralHeight = false;
            this.cbServicio.ItemHeight = 43;
            this.cbServicio.Location = new System.Drawing.Point(147, 122);
            this.cbServicio.MaxDropDownItems = 4;
            this.cbServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(198, 49);
            this.cbServicio.StartIndex = 0;
            this.cbServicio.TabIndex = 16;
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.cbServicio_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(10, 135);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Tipo de turno:";
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
            this.cmbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.IntegralHeight = false;
            this.cmbSucursal.ItemHeight = 43;
            this.cmbSucursal.Location = new System.Drawing.Point(147, 11);
            this.cmbSucursal.MaxDropDownItems = 4;
            this.cmbSucursal.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(198, 49);
            this.cmbSucursal.StartIndex = 0;
            this.cmbSucursal.TabIndex = 14;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(147, 187);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(198, 20);
            this.dtFecha.TabIndex = 10;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // txtDni
            // 
            this.txtDni.AnimateReadOnly = false;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Depth = 0;
            this.txtDni.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDni.LeadingIcon = null;
            this.txtDni.Location = new System.Drawing.Point(147, 66);
            this.txtDni.MaxLength = 50;
            this.txtDni.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDni.Multiline = false;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(198, 50);
            this.txtDni.TabIndex = 9;
            this.txtDni.Text = "";
            this.txtDni.TrailingIcon = null;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(10, 297);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Hora Fin:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(10, 187);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(48, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Fecha:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(10, 80);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(31, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "DNI:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(10, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Sucursal:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 54);
            this.panel2.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(208, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(167, 42);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Crear Turno";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbSubServicio
            // 
            this.cbSubServicio.AutoResize = false;
            this.cbSubServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbSubServicio.Depth = 0;
            this.cbSubServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbSubServicio.DropDownHeight = 174;
            this.cbSubServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubServicio.DropDownWidth = 121;
            this.cbSubServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbSubServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbSubServicio.FormattingEnabled = true;
            this.cbSubServicio.IntegralHeight = false;
            this.cbSubServicio.ItemHeight = 43;
            this.cbSubServicio.Location = new System.Drawing.Point(351, 122);
            this.cbSubServicio.MaxDropDownItems = 4;
            this.cbSubServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbSubServicio.Name = "cbSubServicio";
            this.cbSubServicio.Size = new System.Drawing.Size(198, 49);
            this.cbSubServicio.StartIndex = 0;
            this.cbSubServicio.TabIndex = 20;
            // 
            // FormTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 489);
            this.Controls.Add(this.panel1);
            this.Name = "FormTurno";
            this.Text = "Alta Turno";
            this.Load += new System.EventHandler(this.FormTurno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MaterialSkin.Controls.MaterialTextBox txtDni;
        private MaterialSkin.Controls.MaterialComboBox cmbSucursal;
        private MaterialSkin.Controls.MaterialComboBox cbServicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cbHoraIni;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblHoraFin;
        private MaterialSkin.Controls.MaterialComboBox cbSubServicio;
    }
}