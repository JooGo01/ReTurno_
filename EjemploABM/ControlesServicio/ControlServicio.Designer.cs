namespace EjemploABM.ControlesServicio
{
    partial class ControlServicio
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
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.dgv_evento = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.Controls.Add(this.dgv_evento);
            this.panel_contenedor.Controls.Add(this.panel1);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1124, 515);
            this.panel_contenedor.TabIndex = 2;
            // 
            // dgv_evento
            // 
            this.dgv_evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_evento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.id_sucursal,
            this.id_servicio,
            this.Editar,
            this.Eliminar});
            this.dgv_evento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_evento.Location = new System.Drawing.Point(0, 47);
            this.dgv_evento.Name = "dgv_evento";
            this.dgv_evento.Size = new System.Drawing.Size(1124, 468);
            this.dgv_evento.TabIndex = 3;
            this.dgv_evento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_evento_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // id_sucursal
            // 
            this.id_sucursal.HeaderText = "Sucursal";
            this.id_sucursal.Name = "id_sucursal";
            // 
            // id_servicio
            // 
            this.id_servicio.HeaderText = "Servicio";
            this.id_servicio.Name = "id_servicio";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(1124, 47);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "+";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ControlServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_contenedor);
            this.Name = "ControlServicio";
            this.Size = new System.Drawing.Size(1124, 515);
            this.panel_contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.DataGridView dgv_evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servicio;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
    }
}
