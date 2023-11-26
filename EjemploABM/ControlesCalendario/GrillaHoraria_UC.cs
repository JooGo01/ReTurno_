using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM.ControlesCalendario
{
    public partial class GrillaHoraria_UC : UserControl
    {
        public GrillaHoraria_UC()
        {
            InitializeComponent();
        }

        List<Turno> turnos;
        public List<Atencion> listAtencion;
        public DateTime dt_seleccionado;
        public Sucursal suc_seleccionado;
        public Servicio ser_seleccionado;
        public Atencion atencion;
        public Dia dia;
        public int hora_ini;
        public int hora_fin;
        public int intervalo_minutos;
        public int pos_x = 0;
        public GrillaHoraria_UC(DateTime dt, Sucursal suc, Servicio sc)
        {
            InitializeComponent();
            //cargarTurno(dt, suc);
            dt_seleccionado = dt;
            suc_seleccionado = suc;
            ser_seleccionado = sc;
            DayOfWeek diaDeLaSemana = dt.DayOfWeek;
            int valorDia = 0;
            valorDia = (int)diaDeLaSemana;
            if (valorDia == 0)
            {
                valorDia = 7;
            }
            dia = Dia_Contoller.obtenerPorId(valorDia);
            listAtencion = Atencion_Controller.obtenerTodosSucSer(suc, sc, dia);
            if (listAtencion.Count > 0) {
                atencion = listAtencion[0];
            }
            GenerarGrilla();
        }

        private void panel_contenedor_grillahor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerarGrilla()
        {
            int hora_inicial;
            int hora_final;
            Boolean boolHoraLim;
            boolHoraLim = false;
            DateTime dia_hora = dt_seleccionado;
            DateTime dia_hora_lim = dt_seleccionado;
            panel_contenedor_grillahor.Controls.Clear();
            if (atencion != null)
            {
                hora_inicial = atencion.hora_apertura;
                dia_hora = dia_hora.AddHours(hora_inicial);
                hora_final = atencion.hora_cierre;
                dia_hora_lim = dia_hora_lim.AddHours(hora_final);
                intervalo_minutos = atencion.sucursal_servicio_id.tiempo_servicio;
                agregarInfoFunc();
                while (!boolHoraLim) {
                    if (dia_hora <= dia_hora_lim)
                    {
                        AgregarPanelFila(dia_hora.ToString("HH:mm:ss"), dia_hora);
                        dia_hora = dia_hora.AddMinutes(intervalo_minutos);
                    }
                    else {
                        boolHoraLim = true;
                    }
                }
            }
            else {
                agregarInfo();
            }
        }

        private void AgregarPanelFila(string hora, DateTime fechahora)
        {
            // Crea un nuevo panel para cada fila
            Boolean turno = false;
            List<Turno> listTurno = new List<Turno>();
            listTurno = Calendario_Controller.obtenerPorFechaHora(fechahora, suc_seleccionado, ser_seleccionado);
            if (listTurno.Count > 0) {
                turno = true;
            }
            Panel panelFila = new Panel
            {
                Size = new Size(panel_contenedor_grillahor.Width, 50),
                BorderStyle = BorderStyle.FixedSingle,
                Dock=DockStyle.Bottom
            };
            // Añade un Label al panel para mostrar la hora

            Label labelHora = new Label
            {
                Text = hora,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Calibri", 14),
                Dock = DockStyle.Fill
            };
            labelHora.Click += labelHora_Click;
            labelHora.Name = hora;
            if (turno)
            {
                labelHora.ForeColor = Color.Green;
            }
            else {
                labelHora.ForeColor = Color.Black;
            }
            // Añade el Label al panel
            panelFila.Controls.Add(labelHora);

            // Añade el panel al panel principal (contenedor de la grilla)
            panel_contenedor_grillahor.Controls.Add(panelFila);
        }

        private void agregarInfo() {
            Panel panelFila = new Panel
            {
                Size = new Size(panel_contenedor_grillahor.Width, panel_contenedor_grillahor.Height),
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top
            };
            // Añade un Label al panel para mostrar la hora

            Label labelInfo = new Label
            {
                Text = "No hay atencion de este servicio durante este dia",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Calibri", 18),
                Dock = DockStyle.Fill,
                ForeColor= Color.Red
            };
        
            // Añade el Label al panel
            panelFila.Controls.Add(labelInfo);

            // Añade el panel al panel principal (contenedor de la grilla)
            panel_contenedor_grillahor.Controls.Add(panelFila);
        }

        private void agregarInfoFunc()
        {
            Panel panelFila = new Panel
            {
                Size = new Size(panel_contenedor_grillahor.Width, 100),
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top
            };
            // Añade un Label al panel para mostrar la hora

            Label labelInfo = new Label
            {
                Text = "Haga click sobre una de las grillas horarias para ver los turnos en esa hora y/o agregar algun turno.",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Calibri", 14),
                Dock = DockStyle.Fill,
                ForeColor = Color.Black
            };

            // Añade el Label al panel
            panelFila.Controls.Add(labelInfo);

            // Añade el panel al panel principal (contenedor de la grilla)
            panel_contenedor_grillahor.Controls.Add(panelFila);
        }

        private void labelHora_Click(object sender, EventArgs e)
        {
            Label dia = sender as Label;
            //MessageBox.Show(dia.Name);
            DateTime dtSeleccionado = new DateTime();
            String horaSeleccionada = "";
            String fechaSeleccionada = "";
            String strFecha = "";
            fechaSeleccionada = dt_seleccionado.ToString("dd-MM-yyyy");
            horaSeleccionada=dia.Name.ToString().Substring(dia.Name.ToString().Length - 8);
            string formato = "dd-MM-yyyy HH:mm:ss";
            strFecha = fechaSeleccionada + " " + horaSeleccionada;
            DateTime.TryParseExact(strFecha, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dtSeleccionado);
            frmVisualizarTurno frmTurnos = new frmVisualizarTurno(suc_seleccionado,ser_seleccionado, dtSeleccionado);
            DialogResult dr = frmTurnos.ShowDialog();

            if (dr == DialogResult.OK)
            {

            }
            GenerarGrilla();
        }
    }
}
