using EjemploABM.ControlesDeUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EjemploABM.ControlesCalendario;
using EjemploABM.ControlesDeUsuario;
using EjemploABM.ControlesCliente;
using EjemploABM.ControlesAdm;
using EjemploABM.Modelo;
using MaterialSkin;
using EjemploABM.Controladores;
using System.Net;
using EjemploABM.ControlesSucursal;

namespace EjemploABM
{
    public partial class FormCalendario : MaterialSkin.Controls.MaterialForm
    {
        private InfoMesCalendario _infoCalendario;
        public FormCalendario()
        {
            InitializeComponent();
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            if (Program.logueado.tipo_usuario == "S")
            {
                btnCliente.Enabled = true;
                btnUsuario.Enabled = true;
                btnAdm.Enabled = true;
                btnSuc.Enabled = true;
            }
            else if (Program.logueado.tipo_usuario == "A") {
                btnCliente.Enabled = false;
                btnUsuario.Enabled = true;
                btnAdm.Enabled = true;
                btnSuc.Enabled = true;
            } else if (Program.logueado.tipo_usuario == "V") {
                btnCliente.Enabled = false;
                btnUsuario.Enabled = true;
                btnAdm.Enabled = false;
                btnSuc.Enabled = false;
            }
            crearDias();
            diasSemana();
            ajustePanel();
            _infoCalendario = new InfoMesCalendario(DateTime.Now.Month, DateTime.Now.Year);
            llenarCalendario();
            //pruebaEventos();
            //Calendario_UC calendarioUC = new Calendario_UC();
            //addUserControl(calendarioUC);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT; // or .DARK
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue300, Accent.Red400, TextShade.WHITE);
            btnAchicar.Visible=false;

            List<Sucursal> list = new List<Sucursal>();
            Direccion dire = new Direccion();
            if (Program.logueado.tipo_usuario == "S") {
                list = Sucursal_Controller.obtenerTodosSucCliente(Program.cli);
                foreach (Sucursal suc in list)
                {
                    dire = Direccion_Controller.obtenerPorId(suc.direccion.id);
                    String textoSucursal = suc.id.ToString() + "- " + dire.calle + " " + dire.altura;
                    cmbSucursal.Items.Add(textoSucursal);
                    cmbSucursal.SelectedIndex = 0;
                }
            }
            else {
                list = Sucursal_Controller.obtenerTodosSucClienteAdm(Program.logueado);
                foreach (Sucursal suc in list)
                {
                    dire = Direccion_Controller.obtenerPorId(suc.direccion.id);
                    String textoSucursal = suc.id.ToString() + "- " + dire.calle + " " + dire.altura;
                    cmbSucursal.Items.Add(textoSucursal);
                    cmbSucursal.SelectedIndex = 0;
                }
            }
            //descripcionEventos();
        }

        private void crearDias() {
            Panel diaPanel = new Panel();
            Label diaMes = new Label();
            int indexFila = 0;
            int indexCol = 0;

            for (indexFila = 0; indexFila < 6; indexFila++) { 
                for(indexCol=0; indexCol < 7; indexCol++)
                {
                    diaPanel = new Panel();
                    diaPanel.Name = String.Format("pnlDia{0}{1}", indexFila, indexCol);
                    diaPanel.Click += DiaPanel_Click;
                    diaMes = new Label();
                    diaMes.Name = String.Format("lblDiaMes{0}{1}", indexFila, indexCol);
                    diaMes.Text = diaMes.Name;
                    diaPanel.Controls.Add(diaMes);
                    diaPanel.BorderStyle = BorderStyle.FixedSingle;

                    switch (indexFila) { 
                        case 0:
                            panel_semana0.Controls.Add(diaPanel);
                            break;
                        case 1:
                            panel_semana1.Controls.Add(diaPanel);
                            break;
                        case 2:
                            panel_semana2.Controls.Add(diaPanel);
                            break;
                        case 3:
                            panel_semana3.Controls.Add(diaPanel);
                            break;
                        case 4:
                            panel_semana4.Controls.Add(diaPanel);
                            break;
                        case 5:
                            panel_semana5.Controls.Add(diaPanel);
                            break;
                    }
                }
            }
        }

        private void DiaPanel_Click(object sender, EventArgs e)
        {
            Panel dia = sender as Panel;
            if (dia != null) {
                eventoPanelDia(dia.Name);
            }
        }

        private void eventoPanelDia(String nombre) {
            lblMensajePanel.Text = nombre;
            //indexFila,indexCol
            String filacol = nombre.Substring(nombre.Length - 2);
            int fila = Int32.Parse(filacol.Substring(0,1));
            int col = Int32.Parse(filacol.Substring(1, 1));
            DateTime fecha = _infoCalendario.diaGrilla(fila,col);
            Sucursal suc = new Sucursal();
            String[] id_suc = cmbSucursal.Text.Split('-');
            suc = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            Servicio ser = new Servicio();
            Calendario_UC calendarioUC = new Calendario_UC(fecha,suc, ser);
            addUserControl(calendarioUC);
            lblMensajePanel.Visible = false;
            btnAchicar.BringToFront();
            btnAgrandar.BringToFront();
        }

        private void ajustePanel()
        {
            Panel[] arrPanel = new Panel[] {
                panel_dia_semana,
                panel_semana5,
                panel_semana4,
                panel_semana3,
                panel_semana2,
                panel_semana1,
                panel_semana0,
            };

            foreach (Panel pnl in arrPanel)
            {
                ajustarTamanio(pnl);
            }
        }
        private void ajustarTamanio(Control c) {
            int ancho = 0;
            int x = 0;
            int cantidadItems = 0;
            foreach (Control ctl in c.Controls)
            {
                cantidadItems++;
            }
            if (cantidadItems == 0) {
                return;
            }

            ancho = c.Width / cantidadItems;

            foreach (Control ctl in c.Controls)
            {
                ctl.Height = c.Height;
                ctl.Width = ancho;
                ctl.Location = new Point(x, 0);
                x += ancho;
            }
        }

        private void diasSemana() {
            Panel diaPanel = new Panel();
            Label diaSemana = new Label();
            int indexCol = 0;

            for (indexCol = 0; indexCol < 7; indexCol++)
            {
                diaPanel = new Panel();
                diaPanel.Name = String.Format("pnlDiaSemana{0}{1}", 0, indexCol);
                diaSemana = new Label();
                switch (indexCol)
                {
                    case 0:
                        diaSemana.Name = "Domingo";
                        break;
                    case 1:
                        diaSemana.Name = "Lunes";
                        break;
                    case 2:
                        diaSemana.Name = "Martes";
                        break;
                    case 3:
                        diaSemana.Name = "Miercoles";
                        break;
                    case 4:
                        diaSemana.Name = "Jueves";
                        break;
                    case 5:
                        diaSemana.Name = "Viernes";
                        break;
                    case 6:
                        diaSemana.Name = "Sabado";
                        break;
                }
                diaSemana.Text = diaSemana.Name;
                diaSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                diaSemana.Dock= DockStyle.Left;
                diaSemana.AutoSize = true;
                diaSemana.Font = new Font("Calibri", 14);
                diaSemana.ForeColor = Color.Black;
                diaPanel.Controls.Add(diaSemana);
                diaPanel.BorderStyle = BorderStyle.FixedSingle;
                panel_dia_semana.Controls.Add(diaPanel);
            }
        }

        private void llenarCalendario() {
            Label lbl = new Label();
            Control lblControl = new Control();
            String lblNombre;
            int indexFila = 0;
            int indexCol = 0;

            lbl.Text = String.Format("{0}, {1}", nombreMes(_infoCalendario.getMes()), _infoCalendario.getAnio());
            lbl.Name = "lblInfoMesAnio";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.AutoSize = true;
            lbl.Font = new Font("Cambria", 16);
            panel_control.Controls.Add(lbl);

            for (indexFila = 0; indexFila < 6; indexFila++)
            {
                for (indexCol = 0; indexCol < 7; indexCol++)
                {
                    lblNombre = String.Format("lblDiaMes{0}{1}", indexFila, indexCol);
                    lblControl = Controls.Find(lblNombre, true).First();
                    lblControl.Text = _infoCalendario.diaDeMes(indexFila,indexCol).ToString();
                    lblControl.Dock= DockStyle.Top;
                    lblControl.AutoSize = true;
                    lblControl.Font = new Font("Calibri", 16);

                    if (_infoCalendario.esMesActivo(indexFila, indexCol))
                    {
                        lblControl.ForeColor = Color.Black;
                    }
                    else {
                        lblControl.ForeColor = Color.Gray;
                    }

                    if (_infoCalendario.esHoy(indexFila, indexCol)) {
                        lblControl.ForeColor = Color.Blue;
                    }
                }
            }

        }

        private String nombreMes(int mes) {
            String nombre;
            nombre = "";
            switch (mes) {
                case 1:
                    nombre = "Enero";
                    break;
                case 2:
                    nombre = "Febrero";
                    break;
                case 3:
                    nombre = "Marzo";
                    break;
                case 4:
                    nombre = "Abril";
                    break;
                case 5:
                    nombre = "Mayo";
                    break;
                case 6:
                    nombre = "Junio";
                    break;
                case 7:
                    nombre = "Julio";
                    break;
                case 8:
                    nombre = "Agosto";
                    break;
                case 9:
                    nombre = "Septiembre";
                    break;
                case 10:
                    nombre = "Octubre";
                    break;
                case 11:
                    nombre = "Noviembre";
                    break;
                case 12:
                    nombre = "Diciembre";
                    break;
            }
            return nombre;
        }

        private void descripcionEventos() { 
            List<DateTime> fechas = new List<DateTime>();
            List<String> eventos = new List<String>();
            List<int> cantEventos = new List<int>();
            Sucursal suc = new Sucursal();
            String[] id_suc = cmbSucursal.Text.Split('-');
            suc = Sucursal_Controller.obtenerPorId(Int32.Parse(id_suc[0]));
            int col;
            int fila;
            Panel pnl;
            Label lbl;
            String pnlNombre;
            DateTime primer_dia = _infoCalendario.diaGrilla(0, 0);
            DateTime ultimo_dia = _infoCalendario.diaGrilla(5, 6);
            fechas = Calendario_Controller.obtenerListadoActividad(primer_dia,ultimo_dia,suc);
            cantEventos = Calendario_Controller.obtenerListadoCantActividad(primer_dia, ultimo_dia, suc);
            for (int i = 0; i < fechas.Count; i++)
            {
                eventos.Add("Cantidad Eventos: " + cantEventos[i].ToString());
            }

            for (int i = 0; i < fechas.Count; i++) {
                if (_infoCalendario.fechaExistente(fechas[i]))
                {
                    col = _infoCalendario.fncColumna(fechas[i]);
                    fila = _infoCalendario.fncFila(fechas[i]);
                    pnlNombre = String.Format("pnlDia{0}{1}", fila, col);
                    pnl = (Panel)Controls.Find(pnlNombre, true).First();

                    lbl = new Label();
                    lbl.Name = String.Format("lblEvento{0}{1}", fila, col);
                    if (_infoCalendario.esMesActivo(fila, col))
                    {
                        if (_infoCalendario.fechaPasada(fila, col))
                        {
                            // si es perteneciente al mismo mes, pero ya paso esa fecha, mostramos de otro color
                            lbl.BackColor = Color.DarkGray;
                        }
                        else {
                            // si es perteneciente al mismo mes, mostramos de otro color
                            lbl.BackColor = Color.Lime;
                        }
                    }
                    else
                    {
                        // si no es pertenciente al mismo mes, lo mostramos de otro color
                        if (_infoCalendario.fechaPasada(fila, col))
                        {
                            // si es perteneciente al mismo mes, pero ya paso esa fecha, mostramos de otro color
                            lbl.BackColor = Color.LightGray;
                        }
                        else {
                            lbl.BackColor = Color.DarkGreen;
                        }
                    }
                    
                    lbl.Text = eventos[i];
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lbl.Location = new Point(0, 25);
                    pnl.Controls.Add(lbl);
                    lbl.Dock = DockStyle.Bottom;
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            limpiezaEventos();
            validacionCambioAnioSiguiente();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            limpiezaEventos();
            validacionCambioAnioAnterior();
        }

        private void validacionCambioAnioAnterior() {
            int mes_act = _infoCalendario.getMes();
            int anio_act = _infoCalendario.getAnio();
            int mes_nuevo = 0;
            int anio_nuevo = 0;
            mes_nuevo = mes_act - 1;
            anio_nuevo = anio_act;
            if (mes_nuevo < 1) {
                anio_nuevo = anio_act - 1;
                mes_nuevo = 12;
            }
            _infoCalendario.setMes(mes_nuevo);
            _infoCalendario.setAnio(anio_nuevo);
            _infoCalendario = new InfoMesCalendario(mes_nuevo, anio_nuevo);
            llenarCalendario();
            descripcionEventos();
        }

        private void validacionCambioAnioSiguiente()
        {
            int mes_act = _infoCalendario.getMes();
            int anio_act = _infoCalendario.getAnio();
            int mes_nuevo = 0;
            int anio_nuevo = 0;
            mes_nuevo = mes_act + 1;
            anio_nuevo = anio_act;
            if (mes_nuevo > 12)
            {
                anio_nuevo = anio_act + 1;
                mes_nuevo = 1;
            }
            _infoCalendario.setMes(mes_nuevo);
            _infoCalendario.setAnio(anio_nuevo);
            _infoCalendario = new InfoMesCalendario(mes_nuevo, anio_nuevo);
            llenarCalendario();
            descripcionEventos();
        }

        private void limpiezaEventos()
        {
            foreach (Control ctlEvento in panel_control.Controls) {
                if (ctlEvento.GetType() == typeof(Label))
                {
                    Label lblMesAnio = (Label)ctlEvento;
                    if (lblMesAnio.Name.Contains("lblInfoMesAnio"))
                    {
                        lblMesAnio.Text = String.Empty;
                    }
                }
            }
            foreach (Control ctl in panel_calendario.Controls)
            {
                if (ctl.GetType() == typeof(Panel)) {
                    foreach (Control controlPanelSemana in ctl.Controls) {
                        Trace.WriteLine(controlPanelSemana.GetType().Name);
                        if (controlPanelSemana.GetType() == typeof(Panel))
                        {
                            foreach (Control controlPanelDia in controlPanelSemana.Controls)
                            {
                                Trace.WriteLine(controlPanelDia.GetType().Name);
                                if (controlPanelDia.GetType() == typeof(Label))
                                {
                                    Label lblBusca = (Label)controlPanelDia;
                                    if (lblBusca.Name.Contains("lblEvento"))
                                    {
                                        lblBusca.Text = String.Empty;
                                        lblBusca.BackColor = Color.White;
                                        lblBusca.Hide();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void addUserControl(UserControl uc)
        {
            //uc.Dock = DockStyle.Fill;
            //panel_actividad.Controls.Clear();
            //panel_actividad.Controls.Add(uc);
            panel_listado_turno.Controls.Clear();
            panel_listado_turno.Controls.Add(uc);
            //uc.BringToFront();
        }

        private void btnAchicar_Click(object sender, EventArgs e)
        {
            btnAgrandar.Visible = true;
            panel_actividad.Width = 276;
            btnAchicar.Visible = false;
            btnAgrandar.BringToFront();
            ajustePanel();

        }

        private void btnAgrandar_Click(object sender, EventArgs e)
        {
            btnAchicar.Visible = true;
            panel_actividad.Width = 843;
            btnAgrandar.Visible = false;
            btnAchicar.Location = new Point(780,11);
            btnAchicar.BringToFront();
            ajustePanel();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ControladorCliente cc = new ControladorCliente();
            addUserControlTabAbm(cc);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            addUserControlTabAbm(cu);
        }

        private void addUserControlTabAbm(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_contenedor_abm.Controls.Clear();
            panel_contenedor_abm.Controls.Add(uc);
            uc.BringToFront();
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            _infoCalendario = new InfoMesCalendario(10, 2023);
            limpiezaEventos();
            llenarCalendario();
            descripcionEventos();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            ControladorAdm ca = new ControladorAdm();
            addUserControlTabAbm(ca);
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            ControladorSucursal cs = new ControladorSucursal();
            addUserControlTabAbm(cs);
        }
    }
}
