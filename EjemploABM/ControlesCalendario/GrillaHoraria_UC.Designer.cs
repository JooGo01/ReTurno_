namespace EjemploABM.ControlesCalendario
{
    partial class GrillaHoraria_UC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_contenedor_grillahor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_contenedor_grillahor
            // 
            this.panel_contenedor_grillahor.AutoScroll = true;
            this.panel_contenedor_grillahor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_grillahor.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor_grillahor.Name = "panel_contenedor_grillahor";
            this.panel_contenedor_grillahor.Size = new System.Drawing.Size(843, 512);
            this.panel_contenedor_grillahor.TabIndex = 0;
            this.panel_contenedor_grillahor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_grillahor_Paint);
            // 
            // GrillaHoraria_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_contenedor_grillahor);
            this.Name = "GrillaHoraria_UC";
            this.Size = new System.Drawing.Size(843, 512);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor_grillahor;
    }
}
