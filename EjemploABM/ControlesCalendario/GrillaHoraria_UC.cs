using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DateTime dt_seleccionado;
        public Sucursal suc_seleccionado;
        public DateTime hora_ini;
        public DateTime hora_fin;
        public int intervalo_minutos;
        public GrillaHoraria_UC(DateTime dt, Sucursal suc, Servicio sc)
        {
            InitializeComponent();
            //cargarTurno(dt, suc);
            dt_seleccionado = dt;
            suc_seleccionado = suc;
        }

        private void panel_contenedor_grillahor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerarGrilla()
        {
            DateTime hora_inicial;
            hora_inicial = hora_ini;
            while (hora_inicial <= hora_fin)
            {
                AgregarPanelFila(hora_inicial.ToString("HH:mm"));
                hora_inicial = hora_inicial.AddMinutes(intervalo_minutos);
            }
        }

        private void AgregarPanelFila(string hora)
        {
            // Crea un nuevo panel para cada fila
            Panel panelFila = new Panel
            {
                Size = new Size(panel_contenedor_grillahor.Width, 30),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Añade un Label al panel para mostrar la hora
            Label labelHora = new Label
            {
                Text = hora,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Añade el Label al panel
            panelFila.Controls.Add(labelHora);

            // Añade el panel al panel principal (contenedor de la grilla)
            panel_contenedor_grillahor.Controls.Add(panelFila);
        }

        private void cargarTurno(DateTime dt, Sucursal suc, Servicio ser)
        {
            turnos = Calendario_Controller.obtenerPorFecha(dt, suc, ser);
            
            foreach (Turno trn in turnos)
            {

            }
        }
    }
}
