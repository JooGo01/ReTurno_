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
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
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
    }
}
