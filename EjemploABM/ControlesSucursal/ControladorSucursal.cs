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
                    String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Sucursal suc_baja = new Sucursal();
                    suc_baja = Sucursal_Controller.obtenerPorId(Int32.Parse(id_baja));
                    Sucursal_Controller.bajaSucursal(suc_baja, 1);
                    MessageBox.Show("Sucursal dado de baja con exito", "ReTurno");
                    //TODO - Button Clicked - Execute Code Here
                }

                if (e.ColumnIndex == 4 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //editar
                    /*String id = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Cliente cli = new Cliente();
                    cli = Cliente_Controller.obtenerPorId(Int32.Parse(id));
                    FormClienteEditar frmCliEdit = new FormClienteEditar();

                    DialogResult dr = frmCliEdit.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                    }*/
                    //TODO - Button Clicked - Execute Code Here
                }
            }
        }
    }
}
