namespace EjemploABM
{
    partial class FormCalendario
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
            this.tabControlCalendario = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_calendario = new System.Windows.Forms.TabPage();
            this.panel_contenedor_calendario = new System.Windows.Forms.Panel();
            this.panel_calendario = new System.Windows.Forms.Panel();
            this.panel_dia_semana = new System.Windows.Forms.Panel();
            this.panel_semana0 = new System.Windows.Forms.Panel();
            this.panel_semana1 = new System.Windows.Forms.Panel();
            this.panel_semana2 = new System.Windows.Forms.Panel();
            this.panel_semana3 = new System.Windows.Forms.Panel();
            this.panel_semana4 = new System.Windows.Forms.Panel();
            this.panel_semana5 = new System.Windows.Forms.Panel();
            this.panel_actividad = new System.Windows.Forms.Panel();
            this.panel_listado_turno = new System.Windows.Forms.Panel();
            this.lblMensajePanel = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnAchicar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btnAgrandar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.panel_control = new System.Windows.Forms.Panel();
            this.panel_combo = new System.Windows.Forms.Panel();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialButton();
            this.btnAnterior = new MaterialSkin.Controls.MaterialButton();
            this.tab_abm = new System.Windows.Forms.TabPage();
            this.panel_contenedor_abm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuc = new MaterialSkin.Controls.MaterialButton();
            this.btnAdm = new MaterialSkin.Controls.MaterialButton();
            this.btnUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnCliente = new MaterialSkin.Controls.MaterialButton();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.tabControlCalendario.SuspendLayout();
            this.tab_calendario.SuspendLayout();
            this.panel_contenedor_calendario.SuspendLayout();
            this.panel_calendario.SuspendLayout();
            this.panel_actividad.SuspendLayout();
            this.panel_listado_turno.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.panel_combo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_abm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCalendario
            // 
            this.tabControlCalendario.Controls.Add(this.tab_calendario);
            this.tabControlCalendario.Controls.Add(this.tab_abm);
            this.tabControlCalendario.Depth = 0;
            this.tabControlCalendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCalendario.Location = new System.Drawing.Point(3, 64);
            this.tabControlCalendario.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlCalendario.Multiline = true;
            this.tabControlCalendario.Name = "tabControlCalendario";
            this.tabControlCalendario.SelectedIndex = 0;
            this.tabControlCalendario.Size = new System.Drawing.Size(1138, 588);
            this.tabControlCalendario.TabIndex = 0;
            // 
            // tab_calendario
            // 
            this.tab_calendario.Controls.Add(this.panel_contenedor_calendario);
            this.tab_calendario.Location = new System.Drawing.Point(4, 22);
            this.tab_calendario.Name = "tab_calendario";
            this.tab_calendario.Padding = new System.Windows.Forms.Padding(3);
            this.tab_calendario.Size = new System.Drawing.Size(1130, 562);
            this.tab_calendario.TabIndex = 0;
            this.tab_calendario.Text = "Calendario";
            this.tab_calendario.UseVisualStyleBackColor = true;
            // 
            // panel_contenedor_calendario
            // 
            this.panel_contenedor_calendario.Controls.Add(this.panel_calendario);
            this.panel_contenedor_calendario.Controls.Add(this.panel_actividad);
            this.panel_contenedor_calendario.Controls.Add(this.panel_control);
            this.panel_contenedor_calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_calendario.Location = new System.Drawing.Point(3, 3);
            this.panel_contenedor_calendario.Name = "panel_contenedor_calendario";
            this.panel_contenedor_calendario.Size = new System.Drawing.Size(1124, 556);
            this.panel_contenedor_calendario.TabIndex = 0;
            // 
            // panel_calendario
            // 
            this.panel_calendario.Controls.Add(this.panel_dia_semana);
            this.panel_calendario.Controls.Add(this.panel_semana0);
            this.panel_calendario.Controls.Add(this.panel_semana1);
            this.panel_calendario.Controls.Add(this.panel_semana2);
            this.panel_calendario.Controls.Add(this.panel_semana3);
            this.panel_calendario.Controls.Add(this.panel_semana4);
            this.panel_calendario.Controls.Add(this.panel_semana5);
            this.panel_calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_calendario.Location = new System.Drawing.Point(0, 44);
            this.panel_calendario.Name = "panel_calendario";
            this.panel_calendario.Size = new System.Drawing.Size(848, 512);
            this.panel_calendario.TabIndex = 2;
            // 
            // panel_dia_semana
            // 
            this.panel_dia_semana.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_dia_semana.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_dia_semana.Location = new System.Drawing.Point(0, 0);
            this.panel_dia_semana.Name = "panel_dia_semana";
            this.panel_dia_semana.Size = new System.Drawing.Size(848, 32);
            this.panel_dia_semana.TabIndex = 6;
            // 
            // panel_semana0
            // 
            this.panel_semana0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana0.Location = new System.Drawing.Point(0, 32);
            this.panel_semana0.Name = "panel_semana0";
            this.panel_semana0.Size = new System.Drawing.Size(848, 80);
            this.panel_semana0.TabIndex = 5;
            // 
            // panel_semana1
            // 
            this.panel_semana1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana1.Location = new System.Drawing.Point(0, 112);
            this.panel_semana1.Name = "panel_semana1";
            this.panel_semana1.Size = new System.Drawing.Size(848, 80);
            this.panel_semana1.TabIndex = 4;
            // 
            // panel_semana2
            // 
            this.panel_semana2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana2.Location = new System.Drawing.Point(0, 192);
            this.panel_semana2.Name = "panel_semana2";
            this.panel_semana2.Size = new System.Drawing.Size(848, 80);
            this.panel_semana2.TabIndex = 3;
            // 
            // panel_semana3
            // 
            this.panel_semana3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana3.Location = new System.Drawing.Point(0, 272);
            this.panel_semana3.Name = "panel_semana3";
            this.panel_semana3.Size = new System.Drawing.Size(848, 80);
            this.panel_semana3.TabIndex = 2;
            // 
            // panel_semana4
            // 
            this.panel_semana4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana4.Location = new System.Drawing.Point(0, 352);
            this.panel_semana4.Name = "panel_semana4";
            this.panel_semana4.Size = new System.Drawing.Size(848, 80);
            this.panel_semana4.TabIndex = 1;
            // 
            // panel_semana5
            // 
            this.panel_semana5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_semana5.Location = new System.Drawing.Point(0, 432);
            this.panel_semana5.Name = "panel_semana5";
            this.panel_semana5.Size = new System.Drawing.Size(848, 80);
            this.panel_semana5.TabIndex = 0;
            // 
            // panel_actividad
            // 
            this.panel_actividad.Controls.Add(this.panel_listado_turno);
            this.panel_actividad.Controls.Add(this.panelBotones);
            this.panel_actividad.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_actividad.Location = new System.Drawing.Point(848, 44);
            this.panel_actividad.Name = "panel_actividad";
            this.panel_actividad.Size = new System.Drawing.Size(276, 512);
            this.panel_actividad.TabIndex = 1;
            // 
            // panel_listado_turno
            // 
            this.panel_listado_turno.Controls.Add(this.lblMensajePanel);
            this.panel_listado_turno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_listado_turno.Location = new System.Drawing.Point(0, 0);
            this.panel_listado_turno.Name = "panel_listado_turno";
            this.panel_listado_turno.Size = new System.Drawing.Size(276, 433);
            this.panel_listado_turno.TabIndex = 6;
            // 
            // lblMensajePanel
            // 
            this.lblMensajePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensajePanel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajePanel.Location = new System.Drawing.Point(0, 0);
            this.lblMensajePanel.Name = "lblMensajePanel";
            this.lblMensajePanel.Size = new System.Drawing.Size(276, 433);
            this.lblMensajePanel.TabIndex = 5;
            this.lblMensajePanel.Text = "Haga click en un dia para visualizar la grilla de actividades de esa fecha";
            this.lblMensajePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.btnAchicar);
            this.panelBotones.Controls.Add(this.btnAgrandar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 433);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(276, 79);
            this.panelBotones.TabIndex = 5;
            // 
            // btnAchicar
            // 
            this.btnAchicar.AnimateShowHideButton = true;
            this.btnAchicar.Depth = 0;
            this.btnAchicar.Icon = global::EjemploABM.Properties.Resources.flecha_derecha;
            this.btnAchicar.Location = new System.Drawing.Point(212, 11);
            this.btnAchicar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAchicar.Name = "btnAchicar";
            this.btnAchicar.Size = new System.Drawing.Size(60, 65);
            this.btnAchicar.TabIndex = 1;
            this.btnAchicar.Text = "materialFloatingActionButton1";
            this.btnAchicar.UseVisualStyleBackColor = true;
            this.btnAchicar.Click += new System.EventHandler(this.btnAchicar_Click);
            // 
            // btnAgrandar
            // 
            this.btnAgrandar.Depth = 0;
            this.btnAgrandar.Icon = global::EjemploABM.Properties.Resources.flecha_izquierda;
            this.btnAgrandar.Location = new System.Drawing.Point(6, 11);
            this.btnAgrandar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgrandar.Name = "btnAgrandar";
            this.btnAgrandar.Size = new System.Drawing.Size(60, 65);
            this.btnAgrandar.TabIndex = 0;
            this.btnAgrandar.Text = "materialFloatingActionButton1";
            this.btnAgrandar.UseVisualStyleBackColor = true;
            this.btnAgrandar.Click += new System.EventHandler(this.btnAgrandar_Click);
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.panel_combo);
            this.panel_control.Controls.Add(this.panel1);
            this.panel_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_control.Location = new System.Drawing.Point(0, 0);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(1124, 44);
            this.panel_control.TabIndex = 0;
            // 
            // panel_combo
            // 
            this.panel_combo.Controls.Add(this.cbServicio);
            this.panel_combo.Controls.Add(this.cmbSucursal);
            this.panel_combo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_combo.Location = new System.Drawing.Point(349, 0);
            this.panel_combo.Name = "panel_combo";
            this.panel_combo.Size = new System.Drawing.Size(499, 44);
            this.panel_combo.TabIndex = 1;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(21, 13);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(264, 21);
            this.cmbSucursal.TabIndex = 0;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(848, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSiguiente.HighEmphasis = true;
            this.btnSiguiente.Icon = null;
            this.btnSiguiente.Location = new System.Drawing.Point(212, 0);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSiguiente.Size = new System.Drawing.Size(64, 44);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSiguiente.UseAccentColor = false;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnterior.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnterior.Depth = 0;
            this.btnAnterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnterior.HighEmphasis = true;
            this.btnAnterior.Icon = null;
            this.btnAnterior.Location = new System.Drawing.Point(0, 0);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnterior.Size = new System.Drawing.Size(64, 44);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "<";
            this.btnAnterior.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnterior.UseAccentColor = false;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // tab_abm
            // 
            this.tab_abm.Controls.Add(this.panel_contenedor_abm);
            this.tab_abm.Controls.Add(this.panel2);
            this.tab_abm.Location = new System.Drawing.Point(4, 22);
            this.tab_abm.Name = "tab_abm";
            this.tab_abm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_abm.Size = new System.Drawing.Size(1130, 562);
            this.tab_abm.TabIndex = 1;
            this.tab_abm.Text = "ABM";
            this.tab_abm.UseVisualStyleBackColor = true;
            // 
            // panel_contenedor_abm
            // 
            this.panel_contenedor_abm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor_abm.Location = new System.Drawing.Point(3, 44);
            this.panel_contenedor_abm.Name = "panel_contenedor_abm";
            this.panel_contenedor_abm.Size = new System.Drawing.Size(1124, 515);
            this.panel_contenedor_abm.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuc);
            this.panel2.Controls.Add(this.btnAdm);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 41);
            this.panel2.TabIndex = 0;
            // 
            // btnSuc
            // 
            this.btnSuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSuc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSuc.Depth = 0;
            this.btnSuc.HighEmphasis = true;
            this.btnSuc.Icon = null;
            this.btnSuc.Location = new System.Drawing.Point(332, 3);
            this.btnSuc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSuc.Size = new System.Drawing.Size(95, 36);
            this.btnSuc.TabIndex = 3;
            this.btnSuc.Text = "Sucursal";
            this.btnSuc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSuc.UseAccentColor = false;
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.btnSuc_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdm.Depth = 0;
            this.btnAdm.HighEmphasis = true;
            this.btnAdm.Icon = null;
            this.btnAdm.Location = new System.Drawing.Point(180, 3);
            this.btnAdm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdm.Size = new System.Drawing.Size(144, 36);
            this.btnAdm.TabIndex = 2;
            this.btnAdm.Text = "Administracion";
            this.btnAdm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdm.UseAccentColor = false;
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsuario.Depth = 0;
            this.btnUsuario.HighEmphasis = true;
            this.btnUsuario.Icon = null;
            this.btnUsuario.Location = new System.Drawing.Point(89, 3);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUsuario.Size = new System.Drawing.Size(83, 36);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsuario.UseAccentColor = false;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCliente.Depth = 0;
            this.btnCliente.HighEmphasis = true;
            this.btnCliente.Icon = null;
            this.btnCliente.Location = new System.Drawing.Point(4, 3);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCliente.Size = new System.Drawing.Size(80, 36);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCliente.UseAccentColor = false;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(291, 13);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(197, 21);
            this.cbServicio.TabIndex = 1;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 655);
            this.Controls.Add(this.tabControlCalendario);
            this.DrawerTabControl = this.tabControlCalendario;
            this.Name = "FormCalendario";
            this.Text = "FormCalendario";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            this.tabControlCalendario.ResumeLayout(false);
            this.tab_calendario.ResumeLayout(false);
            this.panel_contenedor_calendario.ResumeLayout(false);
            this.panel_calendario.ResumeLayout(false);
            this.panel_actividad.ResumeLayout(false);
            this.panel_listado_turno.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.panel_combo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_abm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControlCalendario;
        private System.Windows.Forms.TabPage tab_calendario;
        private System.Windows.Forms.TabPage tab_abm;
        private System.Windows.Forms.Panel panel_contenedor_calendario;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Panel panel_calendario;
        private System.Windows.Forms.Panel panel_semana5;
        private System.Windows.Forms.Panel panel_semana0;
        private System.Windows.Forms.Panel panel_semana1;
        private System.Windows.Forms.Panel panel_semana2;
        private System.Windows.Forms.Panel panel_semana3;
        private System.Windows.Forms.Panel panel_semana4;
        private System.Windows.Forms.Panel panel_dia_semana;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnSiguiente;
        private MaterialSkin.Controls.MaterialButton btnAnterior;
        public System.Windows.Forms.Panel panel_actividad;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnAchicar;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnAgrandar;
        private System.Windows.Forms.Panel panel_listado_turno;
        private System.Windows.Forms.Label lblMensajePanel;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panel_contenedor_abm;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnUsuario;
        private MaterialSkin.Controls.MaterialButton btnCliente;
        private MaterialSkin.Controls.MaterialButton btnAdm;
        private MaterialSkin.Controls.MaterialButton btnSuc;
        private System.Windows.Forms.Panel panel_combo;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cbServicio;
    }
}