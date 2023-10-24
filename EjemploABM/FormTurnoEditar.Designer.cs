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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.cmbSucursal = new MaterialSkin.Controls.MaterialComboBox();
            this.dtHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtHoraIni = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSucursal);
            this.panel1.Controls.Add(this.dtHoraFin);
            this.panel1.Controls.Add(this.dtHoraIni);
            this.panel1.Controls.Add(this.dtFechaFin);
            this.panel1.Controls.Add(this.dtFechaIni);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 424);
            this.panel1.TabIndex = 0;
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
            this.btnEditar.Location = new System.Drawing.Point(208, 6);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(158, 36);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar Turno";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
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
            // dtHoraFin
            // 
            this.dtHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraFin.Location = new System.Drawing.Point(353, 214);
            this.dtHoraFin.Name = "dtHoraFin";
            this.dtHoraFin.Size = new System.Drawing.Size(198, 20);
            this.dtHoraFin.TabIndex = 23;
            // 
            // dtHoraIni
            // 
            this.dtHoraIni.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraIni.Location = new System.Drawing.Point(353, 156);
            this.dtHoraIni.Name = "dtHoraIni";
            this.dtHoraIni.Size = new System.Drawing.Size(198, 20);
            this.dtHoraIni.TabIndex = 22;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaFin.Location = new System.Drawing.Point(149, 214);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(198, 20);
            this.dtFechaFin.TabIndex = 21;
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaIni.Location = new System.Drawing.Point(149, 156);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(198, 20);
            this.dtFechaIni.TabIndex = 20;
            // 
            // txtDni
            // 
            this.txtDni.AnimateReadOnly = false;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Depth = 0;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(12, 215);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(74, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Fecha Fin:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(12, 156);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(90, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Fecha Inicio:";
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
        private System.Windows.Forms.DateTimePicker dtHoraFin;
        private System.Windows.Forms.DateTimePicker dtHoraIni;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private MaterialSkin.Controls.MaterialTextBox txtDni;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}