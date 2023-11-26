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

namespace EjemploABM.ControlesServicio
{
    public partial class ControlServicio : UserControl
    {
        public ControlServicio()
        {
            InitializeComponent();
            cargarServicio();
            if (Program.logueado.tipo_usuario == "V")
            {
                btnAgregar.Enabled = false;
            }
        }

        private void cargarServicio()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            List<Servicio> servicio = new List<Servicio>();
            List<SucursalServicio> sucServicio = new List<SucursalServicio>();
            Cliente cli = new Cliente();
            cli = Cliente_Controller.obtenerPorId(Program.cli.id);
            sucServicio = SucServ_Controller.obtenerTodosActivos(cli);
            
            dgv_evento.Rows.Clear();
            if (sucServicio != null) {
                foreach (SucursalServicio sucServ in sucServicio)
                {
                    int rowIndex = dgv_evento.Rows.Add();

                    dgv_evento.Rows[rowIndex].Cells[0].Value = sucServ.id.ToString();
                    dgv_evento.Rows[rowIndex].Cells[1].Value = sucServ.id_sucursal.id.ToString();
                    dgv_evento.Rows[rowIndex].Cells[2].Value = sucServ.id_servicio.id.ToString();
                    dgv_evento.Rows[rowIndex].Cells[3].Value = "Editar";
                    dgv_evento.Rows[rowIndex].Cells[4].Value = "Eliminar";
                }
            }
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
            if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value) != null)
            {
                if (e.ColumnIndex == 5 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        SucursalServicio sucServ_baja = new SucursalServicio();
                        sucServ_baja = SucServ_Controller.obtenerPorId(Int32.Parse(id_baja));
                        SucServ_Controller.bajaSucServicio(sucServ_baja, 1);
                        MessageBox.Show("Servicio dado de baja con exito", "ReTurno");
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
                    }
                    //TODO - Button Clicked - Execute Code Here
                }

                if (e.ColumnIndex == 4 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        //editar
                        String id = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        SucursalServicio suc = new SucursalServicio();
                        suc = SucServ_Controller.obtenerPorId(Int32.Parse(id));
                        FormSucursalEditar frmSucEdit = new FormSucursalEditar(suc);

                        DialogResult dr = frmSucEdit.ShowDialog();

                        if (dr == DialogResult.OK)
                        {
                        }
                        //TODO - Button Clicked - Execute Code Here
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos suficientes para realizar la edicion de la sucursal", "ReTurno");
                    }
                }
            }*/
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
            {
                //agregar
                frmServicio frmSer = new frmServicio();

                DialogResult dr = frmSer.ShowDialog();

                if (dr == DialogResult.OK)
                {
                }
                //TODO - Button Clicked - Execute Code Here
                cargarServicio();
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos suficientes para realizar el alta de la sucursal", "ReTurno");
            }
        }
    }
}
