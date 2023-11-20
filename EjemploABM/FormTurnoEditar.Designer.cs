namespace EjemploABM
{
    partial class FormTurnoEditar
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
            this.cbServicio = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSucursal = new MaterialSkin.Controls.MaterialComboBox();
            this.txtDni = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.lblHoraFin = new MaterialSkin.Controls.MaterialLabel();
            this.cbHoraIni = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHoraFin);
            this.panel1.Controls.Add(this.cbHoraIni);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.cbServicio);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.cmbSucursal);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 424);
            this.panel1.TabIndex = 0;
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
            this.cbServicio.Location = new System.Drawing.Point(149, 121);
            this.cbServicio.MaxDropDownItems = 4;
            this.cbServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(198, 49);
            this.cbServicio.StartIndex = 0;
            this.cbServicio.TabIndex = 26;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(12, 134);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 19);
            this.materialLabel5.TabIndex = 25;
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
            this.cmbSucursal.Location = new System.Drawing.Point(149, 10);
            this.cmbSucursal.MaxDropDownItems = 4;
            this.cmbSucursal.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(198, 49);
            this.cmbSucursal.StartIndex = 0;
            this.cmbSucursal.TabIndex = 24;
            // 
            // txtDni
            // 
            this.txtDni.AnimateReadOnly = false;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Depth = 0;
            this.txtDni.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDni.LeadingIcon = null;
            this.txtDni.Location = new System.Drawing.Point(149, 65);
            this.txtDni.MaxLength = 50;
            this.txtDni.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDni.Multiline = false;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(198, 50);
            this.txtDni.TabIndex = 19;
            this.txtDni.Text = "";
            this.txtDni.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(12, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(31, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "DNI:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Sucursal:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(224, 6);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(123, 36);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar Turno";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Depth = 0;
            this.lblHoraFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoraFin.Location = new System.Drawing.Point(146, 301);
            this.lblHoraFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(1, 0);
            this.lblHoraFin.TabIndex = 34;
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
            this.cbHoraIni.Location = new System.Drawing.Point(149, 227);
            this.cbHoraIni.MaxDropDownItems = 4;
            this.cbHoraIni.MouseState = MaterialSkin.MouseState.OUT;
            this.cbHoraIni.Name = "cbHoraIni";
            this.cbHoraIni.Size = new System.Drawing.Size(198, 49);
            this.cbHoraIni.StartIndex = 0;
            this.cbHoraIni.TabIndex = 33;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(12, 240);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "Hora Inicio:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(149, 191);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(198, 20);
            this.dtFecha.TabIndex = 29;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(12, 301);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 28;
            this.materialLabel4.Text = "Hora Fin:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(12, 191);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(48, 19);
            this.materialLabel7.TabIndex = 27;
            this.materialLabel7.Text = "Fecha:";
            // 
            // FormTurnoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 491);
            this.Controls.Add(this.panel1);
            this.Name = "FormTurnoEditar";
            this.Text = "Editar Turno";
            this.Load += new System.EventHandler(this.FormTurnoEditar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialComboBox cmbSucursal;
        private MaterialSkin.Controls.MaterialTextBox txtDni;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cbServicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblHoraFin;
        private MaterialSkin.Controls.MaterialComboBox cbHoraIni;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}