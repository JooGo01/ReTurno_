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
        public DateTime dt_seleccionado;
        public Sucursal suc_seleccionado;
        public Calendario_UC(DateTime dt, Sucursal suc, Servicio ser)
        {
            InitializeComponent();
            cargarTurno(dt, suc, ser);
            dt_seleccionado = dt;
            suc_seleccionado = suc;
        }

        private void cargarTurno(DateTime dt, Sucursal suc, Servicio ser)
        {
            turnos = Calendario_Controller.obtenerPorFecha(dt, suc, ser);
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

            FormTurno frmTurno = new FormTurno();
            DialogResult dr = frmTurno.ShowDialog();

            if (dr == DialogResult.OK)
            {

            }
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
            if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value)!=null) {
                if (e.ColumnIndex == 7 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Calendario_Controller.bajarTurno(Int32.Parse(id_baja));
                        MessageBox.Show("Turno dado de baja con exito", "ReTurno");
                        //TODO - Button Clicked - Execute Code Here
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
                    }
                }

                if (e.ColumnIndex == 6 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //editar
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        FormTurnoEditar frmCalendario = new FormTurnoEditar();
                        String id = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        frmCalendario.cargarTurno(Int32.Parse(id));
                        DialogResult dr = frmCalendario.ShowDialog();

                        if (dr == DialogResult.OK)
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
                    }
                    //TODO - Button Clicked - Execute Code Here
                }
            }
        }
    }
}
