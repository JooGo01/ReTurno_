﻿namespace EjemploABM
{
    partial class frmAtencion
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
            this.pnael_contenedor = new System.Windows.Forms.Panel();
            this.cbServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.pnl_contenedor_dia = new System.Windows.Forms.Panel();
            this.cmbCantPersonal = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbHoraFin = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbHoraIni = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTiempo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnl_contenedor_suc = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pnael_contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnael_contenedor
            // 
            this.pnael_contenedor.Controls.Add(this.cbServicio);
            this.pnael_contenedor.Controls.Add(this.pnl_contenedor_dia);
            this.pnael_contenedor.Controls.Add(this.cmbCantPersonal);
            this.pnael_contenedor.Controls.Add(this.cmbHoraFin);
            this.pnael_contenedor.Controls.Add(this.cmbHoraIni);
            this.pnael_contenedor.Controls.Add(this.materialLabel5);
            this.pnael_contenedor.Controls.Add(this.materialLabel4);
            this.pnael_contenedor.Controls.Add(this.materialLabel3);
            this.pnael_contenedor.Controls.Add(this.txtTiempo);
            this.pnael_contenedor.Controls.Add(this.materialLabel1);
            this.pnael_contenedor.Controls.Add(this.pnl_contenedor_suc);
            this.pnael_contenedor.Controls.Add(this.panel1);
            this.pnael_contenedor.Controls.Add(this.materialLabel2);
            this.pnael_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnael_contenedor.Location = new System.Drawing.Point(3, 64);
            this.pnael_contenedor.Name = "pnael_contenedor";
            this.pnael_contenedor.Size = new System.Drawing.Size(794, 575);
            this.pnael_contenedor.TabIndex = 1;
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
            this.cbServicio.Location = new System.Drawing.Point(183, 16);
            this.cbServicio.MaxDropDownItems = 4;
            this.cbServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(459, 49);
            this.cbServicio.StartIndex = 0;
            this.cbServicio.TabIndex = 26;
            // 
            // pnl_contenedor_dia
            // 
            this.pnl_contenedor_dia.AutoScroll = true;
            this.pnl_contenedor_dia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_contenedor_dia.Location = new System.Drawing.Point(0, 318);
            this.pnl_contenedor_dia.Name = "pnl_contenedor_dia";
            this.pnl_contenedor_dia.Size = new System.Drawing.Size(794, 82);
            this.pnl_contenedor_dia.TabIndex = 25;
            // 
            // cmbCantPersonal
            // 
            this.cmbCantPersonal.AutoResize = false;
            this.cmbCantPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCantPersonal.Depth = 0;
            this.cmbCantPersonal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCantPersonal.DropDownHeight = 174;
            this.cmbCantPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantPersonal.DropDownWidth = 121;
            this.cmbCantPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCantPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCantPersonal.FormattingEnabled = true;
            this.cmbCantPersonal.IntegralHeight = false;
            this.cmbCantPersonal.ItemHeight = 43;
            this.cmbCantPersonal.Location = new System.Drawing.Point(183, 239);
            this.cmbCantPersonal.MaxDropDownItems = 4;
            this.cmbCantPersonal.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCantPersonal.Name = "cmbCantPersonal";
            this.cmbCantPersonal.Size = new System.Drawing.Size(134, 49);
            this.cmbCantPersonal.StartIndex = 0;
            this.cmbCantPersonal.TabIndex = 24;
            // 
            // cmbHoraFin
            // 
            this.cmbHoraFin.AutoResize = false;
            this.cmbHoraFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbHoraFin.Depth = 0;
            this.cmbHoraFin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbHoraFin.DropDownHeight = 174;
            this.cmbHoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraFin.DropDownWidth = 121;
            this.cmbHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHoraFin.FormattingEnabled = true;
            this.cmbHoraFin.IntegralHeight = false;
            this.cmbHoraFin.ItemHeight = 43;
            this.cmbHoraFin.Location = new System.Drawing.Point(183, 184);
            this.cmbHoraFin.MaxDropDownItems = 4;
            this.cmbHoraFin.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHoraFin.Name = "cmbHoraFin";
            this.cmbHoraFin.Size = new System.Drawing.Size(134, 49);
            this.cmbHoraFin.StartIndex = 0;
            this.cmbHoraFin.TabIndex = 23;
            // 
            // cmbHoraIni
            // 
            this.cmbHoraIni.AutoResize = false;
            this.cmbHoraIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbHoraIni.Depth = 0;
            this.cmbHoraIni.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbHoraIni.DropDownHeight = 174;
            this.cmbHoraIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraIni.DropDownWidth = 121;
            this.cmbHoraIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbHoraIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbHoraIni.FormattingEnabled = true;
            this.cmbHoraIni.IntegralHeight = false;
            this.cmbHoraIni.ItemHeight = 43;
            this.cmbHoraIni.Location = new System.Drawing.Point(183, 128);
            this.cmbHoraIni.MaxDropDownItems = 4;
            this.cmbHoraIni.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbHoraIni.Name = "cmbHoraIni";
            this.cmbHoraIni.Size = new System.Drawing.Size(134, 49);
            this.cmbHoraIni.StartIndex = 0;
            this.cmbHoraIni.TabIndex = 22;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(3, 256);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(135, 19);
            this.materialLabel5.TabIndex = 20;
            this.materialLabel5.Text = "Cantidad Personal:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(3, 200);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(97, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Hora Fin (hs):";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(3, 144);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Hora Inicio (hs):";
            // 
            // txtTiempo
            // 
            this.txtTiempo.AnimateReadOnly = false;
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Depth = 0;
            this.txtTiempo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTiempo.LeadingIcon = null;
            this.txtTiempo.Location = new System.Drawing.Point(183, 71);
            this.txtTiempo.MaxLength = 50;
            this.txtTiempo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTiempo.Multiline = false;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(134, 50);
            this.txtTiempo.TabIndex = 15;
            this.txtTiempo.Text = "";
            this.txtTiempo.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(161, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Tiempo Servicio (min):";
            // 
            // pnl_contenedor_suc
            // 
            this.pnl_contenedor_suc.AutoScroll = true;
            this.pnl_contenedor_suc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_contenedor_suc.Location = new System.Drawing.Point(0, 400);
            this.pnl_contenedor_suc.Name = "pnl_contenedor_suc";
            this.pnl_contenedor_suc.Size = new System.Drawing.Size(794, 119);
            this.pnl_contenedor_suc.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 56);
            this.panel1.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(284, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(155, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Atencion";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(3, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Servicio:";
            // 
            // frmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.pnael_contenedor);
            this.Name = "frmAtencion";
            this.Text = "Agregar Atencion";
            this.Load += new System.EventHandler(this.frmAtencion_Load);
            this.pnael_contenedor.ResumeLayout(false);
            this.pnael_contenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnael_contenedor;
        private System.Windows.Forms.Panel pnl_contenedor_dia;
        private MaterialSkin.Controls.MaterialComboBox cmbCantPersonal;
        private MaterialSkin.Controls.MaterialComboBox cmbHoraFin;
        private MaterialSkin.Controls.MaterialComboBox cmbHoraIni;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtTiempo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel pnl_contenedor_suc;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbServicio;
    }
}