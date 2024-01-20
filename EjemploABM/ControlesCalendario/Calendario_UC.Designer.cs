namespace EjemploABM.ControlesCalendario
{
    partial class Calendario_UC
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
            this.btnAgregarEvento = new MaterialSkin.Controls.MaterialButton();
            this.dgv_evento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_contenedor_dgv = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSbServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_contenedor_dgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarEvento.Depth = 0;
            this.btnAgregarEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarEvento.HighEmphasis = true;
            this.btnAgregarEvento.Icon = null;
            this.btnAgregarEvento.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarEvento.Size = new System.Drawing.Size(843, 36);
            this.btnAgregarEvento.TabIndex = 0;
            this.btnAgregarEvento.Text = "+";
            this.btnAgregarEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarEvento.UseAccentColor = false;
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // dgv_evento
            // 
            this.dgv_evento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_evento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.horario_inicio,
            this.horario_fin,
            this.Servicio,
            this.colSbServicio,
            this.Eliminar});
            this.dgv_evento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_evento.Location = new System.Drawing.Point(0, 0);
            this.dgv_evento.Name = "dgv_evento";
            this.dgv_evento.Size = new System.Drawing.Size(843, 476);
            this.dgv_evento.TabIndex = 2;
            this.dgv_evento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_evento_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregarEvento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 36);
            this.panel1.TabIndex = 3;
            // 
            // panel_contenedor_dgv
            // 
            this.panel_contenedor_dgv.Controls.Add(this.dgv_evento);
            this.panel_contenedor_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_dgv.Location = new System.Drawing.Point(0, 36);
            this.panel_contenedor_dgv.Name = "panel_contenedor_dgv";
            this.panel_contenedor_dgv.Size = new System.Drawing.Size(843, 476);
            this.panel_contenedor_dgv.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // horario_inicio
            // 
            this.horario_inicio.HeaderText = "Horario Inicio";
            this.horario_inicio.Name = "horario_inicio";
            // 
            // horario_fin
            // 
            this.horario_fin.HeaderText = "Horario Fin";
            this.horario_fin.Name = "horario_fin";
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Servicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSbServicio
            // 
            this.colSbServicio.HeaderText = "SubServicio";
            this.colSbServicio.Name = "colSbServicio";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // Calendario_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_contenedor_dgv);
            this.Controls.Add(this.panel1);
            this.Name = "Calendario_UC";
            this.Size = new System.Drawing.Size(843, 512);
            this.Load += new System.EventHandler(this.Calendario_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_evento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_contenedor_dgv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAgregarEvento;
        private System.Windows.Forms.DataGridView dgv_evento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_contenedor_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSbServicio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
