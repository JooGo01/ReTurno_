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

namespace EjemploABM.ControlesSucursal
{
    public partial class ControladorSucursal : UserControl
    {
        public ControladorSucursal()
        {
            InitializeComponent();
            cargarSucursales();
            if (Program.logueado.tipo_usuario == "V") {
                btnAgregar.Enabled = false;
            }
        }

        private void cargarSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            if (Program.logueado.tipo_usuario == "S")
            {
                sucursales = Sucursal_Controller.obtenerTodosSucCliente(Program.cli);
            }
            else
            {
                sucursales = Sucursal_Controller.obtenerTodosSucClienteAdm(Program.logueado);
            }
            dgv_evento.Rows.Clear();
            foreach (Sucursal suc in sucursales)
            {
                int rowIndex = dgv_evento.Rows.Add();

                dgv_evento.Rows[rowIndex].Cells[0].Value = suc.id.ToString();
                dgv_evento.Rows[rowIndex].Cells[1].Value = suc.direccion.calle.ToString();
                dgv_evento.Rows[rowIndex].Cells[2].Value = suc.direccion.provincia.ToString();
                dgv_evento.Rows[rowIndex].Cells[3].Value = suc.direccion.ciudad.ToString();
                dgv_evento.Rows[rowIndex].Cells[4].Value = "Editar";
                dgv_evento.Rows[rowIndex].Cells[5].Value = "Eliminar";
            }
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
            if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value) != null)
            {
                if (e.ColumnIndex == 5 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Sucursal suc_baja = new Sucursal();
                        suc_baja = Sucursal_Controller.obtenerPorId(Int32.Parse(id_baja));
                        Sucursal_Controller.bajaSucursal(suc_baja, 1);
                        MessageBox.Show("Sucursal dado de baja con exito", "ReTurno");
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
                        Sucursal suc = new Sucursal();
                        suc = Sucursal_Controller.obtenerPorId(Int32.Parse(id));
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
            }
        }
    }
}
