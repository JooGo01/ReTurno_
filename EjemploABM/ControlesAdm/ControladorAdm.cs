using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Modelo;
using EjemploABM.Controladores;

namespace EjemploABM.ControlesAdm
{
    public partial class ControladorAdm : UserControl
    {
        public ControladorAdm()
        {
            InitializeComponent();
            cargarAdminsitracion();
            if (Program.logueado.tipo_usuario == "V") {
                btnAgregar.Enabled = false;
            }
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
            {
                if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value) != null)
                {
                    if (e.ColumnIndex == 6 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        //eliminar
                        String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Administracion adm = new Administracion();
                        adm = Administracion_Controller.obtenerPorId(Int32.Parse(id_baja));
                        Administracion_Controller.bajaAdministracion(adm);
                        MessageBox.Show("Administracion dado de baja con exito", "ReTurno");
                        //TODO - Button Clicked - Execute Code Here
                    }
                }
            }
            else {
                MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
            }
        }

        private void cargarAdminsitracion()
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Administracion> administra = new List<Administracion>();

            administra = Administracion_Controller.obtenerTodosCliente(Program.cli);
            dgv_evento.Rows.Clear();
            foreach (Administracion adm in administra)
            {
                int rowIndex = dgv_evento.Rows.Add();

                dgv_evento.Rows[rowIndex].Cells[0].Value = adm.id.ToString();
                dgv_evento.Rows[rowIndex].Cells[1].Value = adm.suc.id.ToString();
                dgv_evento.Rows[rowIndex].Cells[2].Value = adm.suc.direccion.calle.ToString();
                dgv_evento.Rows[rowIndex].Cells[3].Value = adm.suc.direccion.provincia.ToString();
                dgv_evento.Rows[rowIndex].Cells[4].Value = adm.suc.direccion.ciudad.ToString();
                dgv_evento.Rows[rowIndex].Cells[5].Value = adm.usuario.id.ToString();
                dgv_evento.Rows[rowIndex].Cells[6].Value = adm.usuario.email.ToString();
                dgv_evento.Rows[rowIndex].Cells[7].Value = "Eliminar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
            {
                FormAdministracion frmAdm = new FormAdministracion();
                DialogResult dr = frmAdm.ShowDialog();

                if (dr == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
            }
        }
    }
}
