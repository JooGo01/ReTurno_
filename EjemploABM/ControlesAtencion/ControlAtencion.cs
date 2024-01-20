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

namespace EjemploABM.ControlesAtencion
{
    public partial class ControlAtencion : UserControl
    {
        public ControlAtencion()
        {
            InitializeComponent();
            cargarAtencion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Program.logueado.tipo_usuario == "A")
            {
                //agregar
                frmAtencion frmAtencion = new frmAtencion();

                DialogResult dr = frmAtencion.ShowDialog();

                if (dr == DialogResult.OK)
                {
                }
                //TODO - Button Clicked - Execute Code Here
                cargarAtencion();
            }
            else
            {
                MessageBox.Show("No cuenta con los permisos suficientes para realizar el alta de la sucursal", "ReTurno");
            }
        }

        private void cargarAtencion()
        {
            List<Atencion> listAtencion = new List<Atencion>();
            listAtencion = Atencion_Controller.obtenerTodosActivos(Program.cli);
            dgv_evento.Rows.Clear();
            if (listAtencion != null)
            {
                foreach (Atencion atencion in listAtencion)
                {
                    int rowIndex = dgv_evento.Rows.Add();

                    dgv_evento.Rows[rowIndex].Cells[0].Value = atencion.id.ToString();
                    dgv_evento.Rows[rowIndex].Cells[1].Value = atencion.sucursal_servicio_id.id_sucursal.id.ToString();
                    dgv_evento.Rows[rowIndex].Cells[2].Value = atencion.sucursal_servicio_id.id_sucursal.direccion.calle.ToString();
                    dgv_evento.Rows[rowIndex].Cells[3].Value = atencion.sucursal_servicio_id.id_sucursal.direccion.altura.ToString();
                    dgv_evento.Rows[rowIndex].Cells[4].Value = atencion.sucursal_servicio_id.id_sucursal.direccion.ciudad.ToString();
                    dgv_evento.Rows[rowIndex].Cells[5].Value = atencion.sucursal_servicio_id.id_sucursal.direccion.provincia.ToString();
                    dgv_evento.Rows[rowIndex].Cells[6].Value = atencion.sucursal_servicio_id.id_subservicio.nombre_servicio.ToString();
                    dgv_evento.Rows[rowIndex].Cells[7].Value = atencion.dia_id.nombre_dia.ToString();
                    dgv_evento.Rows[rowIndex].Cells[8].Value = atencion.hora_apertura.ToString();
                    dgv_evento.Rows[rowIndex].Cells[9].Value = atencion.hora_cierre.ToString();
                    dgv_evento.Rows[rowIndex].Cells[10].Value = "Editar";
                    dgv_evento.Rows[rowIndex].Cells[11].Value = "Eliminar";
                }
            }
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value) != null)
            {
                if (e.ColumnIndex == 10 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        String id_editar = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Atencion atencion_editar = new Atencion();
                        atencion_editar = Atencion_Controller.obtenerPorId(Int32.Parse(id_editar));

                        frmAtencionEditar frmAtencion = new frmAtencionEditar(atencion_editar);

                        DialogResult dr = frmAtencion.ShowDialog();

                        if (dr == DialogResult.OK)
                        {
                        }
                        cargarAtencion();
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
                    }
                    //TODO - Button Clicked - Execute Code Here
                } else if (e.ColumnIndex == 11 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    if (Program.logueado.tipo_usuario == "S" || Program.logueado.tipo_usuario == "A")
                    {
                        String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Atencion atencion_baja = new Atencion();
                        atencion_baja = Atencion_Controller.obtenerPorId(Int32.Parse(id_baja));
                        Atencion_Controller.bajaAtencion(atencion_baja);
                        MessageBox.Show("Atencion dado de baja con exito", "ReTurno");
                        cargarAtencion();
                    }
                    else
                    {
                        MessageBox.Show("No cuenta con los permisos suficientes para realizar una baja", "ReTurno");
                    }
                }
            }
        }
    }
}
