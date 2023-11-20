namespace EjemploABM
{
    partial class frmServicio
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
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.txtServicio = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_contenedor_suc = new System.Windows.Forms.Panel();
            this.pnael_contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnael_contenedor
            // 
            this.pnael_contenedor.Controls.Add(this.pnl_contenedor_suc);
            this.pnael_contenedor.Controls.Add(this.panel1);
            this.pnael_contenedor.Controls.Add(this.txtServicio);
            this.pnael_contenedor.Controls.Add(this.materialLabel2);
            this.pnael_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnael_contenedor.Location = new System.Drawing.Point(3, 64);
            this.pnael_contenedor.Name = "pnael_contenedor";
            this.pnael_contenedor.Size = new System.Drawing.Size(536, 411);
            this.pnael_contenedor.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(191, 6);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(155, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Servicio";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtServicio
            // 
            this.txtServicio.AnimateReadOnly = false;
            this.txtServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicio.Depth = 0;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServicio.LeadingIcon = null;
            this.txtServicio.Location = new System.Drawing.Point(94, 15);
            this.txtServicio.MaxLength = 50;
            this.txtServicio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServicio.Multiline = false;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(428, 50);
            this.txtServicio.TabIndex = 11;
            this.txtServicio.Text = "";
            this.txtServicio.TrailingIcon = null;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 56);
            this.panel1.TabIndex = 12;
            // 
            // pnl_contenedor_suc
            // 
            this.pnl_contenedor_suc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_contenedor_suc.Location = new System.Drawing.Point(0, 71);
            this.pnl_contenedor_suc.Name = "pnl_contenedor_suc";
            this.pnl_contenedor_suc.Size = new System.Drawing.Size(536, 284);
            this.pnl_contenedor_suc.TabIndex = 13;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 478);
            this.Controls.Add(this.pnael_contenedor);
            this.Name = "frmServicio";
            this.Text = "Alta Servicio";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            this.pnael_contenedor.ResumeLayout(false);
            this.pnael_contenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnael_contenedor;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox txtServicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel pnl_contenedor_suc;
        private System.Windows.Forms.Panel panel1;
    }
}