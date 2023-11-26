namespace EjemploABM
{
    partial class frmVisualizarTurno
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
            this.panel_contenedor_turnos = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_contenedor_turnos
            // 
            this.panel_contenedor_turnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_turnos.Location = new System.Drawing.Point(3, 64);
            this.panel_contenedor_turnos.Name = "panel_contenedor_turnos";
            this.panel_contenedor_turnos.Size = new System.Drawing.Size(1118, 533);
            this.panel_contenedor_turnos.TabIndex = 0;
            this.panel_contenedor_turnos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_turnos_Paint);
            // 
            // frmVisualizarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 600);
            this.Controls.Add(this.panel_contenedor_turnos);
            this.Name = "frmVisualizarTurno";
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.frmVisualizarTurno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor_turnos;
    }
}