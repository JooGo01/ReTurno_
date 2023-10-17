using MaterialSkin;
using MaterialSkin.Controls;
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
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM.ControlesCalendario
{
    public partial class Calendario_UC : UserControl
    {

        List<Turno> turnos;
        public Calendario_UC(DateTime dt)
        {
            InitializeComponent();
            cargarTurno(dt);
        }

        private void cargarTurno(DateTime dt)
        {
            turnos = Calendario_Controller.obtenerPorFecha(dt);
            dgv_evento.Rows.Clear();
            foreach (Turno trn in turnos)
            {
                int rowIndex = dgv_evento.Rows.Add();

                dgv_evento.Rows[rowIndex].Cells[0].Value = trn.id.ToString();
                dgv_evento.Rows[rowIndex].Cells[1].Value = trn.usuario.nombre.ToString();
                dgv_evento.Rows[rowIndex].Cells[2].Value = trn.usuario.apellido.ToString();
                dgv_evento.Rows[rowIndex].Cells[3].Value = trn.usuario.dni.ToString();
                dgv_evento.Rows[rowIndex].Cells[4].Value = trn.fecha_ini.ToString();
                dgv_evento.Rows[rowIndex].Cells[5].Value = trn.fecha_fin.ToString();
                dgv_evento.Rows[rowIndex].Cells[6].Value = "Editar";
                dgv_evento.Rows[rowIndex].Cells[7].Value = "Eliminar";
            }
        }

        private void Calendario_UC_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
