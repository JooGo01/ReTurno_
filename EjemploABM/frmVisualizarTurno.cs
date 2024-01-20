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
using EjemploABM.ControlesCalendario;

namespace EjemploABM
{
    public partial class frmVisualizarTurno : MaterialSkin.Controls.MaterialForm
    {
        public DateTime dt_seleccionado;
        public Sucursal suc_seleccionado;
        public SubServicio ser_seleccionado;
        public frmVisualizarTurno()
        {
            InitializeComponent();
        }

        public frmVisualizarTurno(Sucursal suc, SubServicio ser, DateTime dt)
        {
            InitializeComponent();
            dt_seleccionado= dt;
            ser_seleccionado = ser;
            suc_seleccionado = suc;
            Calendario_UC calendario = new Calendario_UC(dt, suc, ser);
            addUserControl(calendario);
        }

        private void frmVisualizarTurno_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_contenedor_turnos.Controls.Clear();
            panel_contenedor_turnos.Controls.Add(uc);
            uc.BringToFront();
        }

        private void panel_contenedor_turnos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
