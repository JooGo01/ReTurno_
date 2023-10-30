using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class ControladorUsuario : UserControl
    {
        List<Usuario> usuarios;
        public ControladorUsuario()
        {
            InitializeComponent();
            cargarUsuarios(0);
        }

        private void cargarUsuarios(int opcUsuario)
        {

            usuarios = Usuario_Controller.obtenerTodos();
            dgv_evento.Rows.Clear();
            foreach (Usuario usr in usuarios)
            {
                int rowIndex = dgv_evento.Rows.Add();

                dgv_evento.Rows[rowIndex].Cells[0].Value = usr.id.ToString();
                dgv_evento.Rows[rowIndex].Cells[1].Value = usr.nombre.ToString();
                dgv_evento.Rows[rowIndex].Cells[2].Value = usr.apellido.ToString();
                dgv_evento.Rows[rowIndex].Cells[3].Value = usr.dni.ToString();
                dgv_evento.Rows[rowIndex].Cells[4].Value = usr.telefono.ToString();
                dgv_evento.Rows[rowIndex].Cells[5].Value = usr.email.ToString();
                dgv_evento.Rows[rowIndex].Cells[6].Value = "Editar";
                dgv_evento.Rows[rowIndex].Cells[7].Value = "Eliminar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormUsuario frmUser = new FormUsuario();
            DialogResult dr = frmUser.ShowDialog();

            if (dr == DialogResult.OK)
            {

            }
        }

        private void dgv_evento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            //String id_check = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
            if ((dgv_evento.Rows[e.RowIndex].Cells[0].Value) != null)
            {
                if (e.ColumnIndex == 7 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //eliminar
                    String id_baja = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Usuario usrBaja = Usuario_Controller.obtenerPorId(Int32.Parse(id_baja));
                    Usuario_Controller.bajaUsuario(usrBaja);
                    MessageBox.Show("Usuario dado de baja con exito", "ReTurno");
                    //TODO - Button Clicked - Execute Code Here
                }

                if (e.ColumnIndex == 6 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    //editar
                    String id = dgv_evento.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Usuario usr = new Usuario();
                    usr = Usuario_Controller.obtenerPorId(Int32.Parse(id));
                    FormUsuarioEditar frmUsrEdit = new FormUsuarioEditar(usr);
                    
                    DialogResult dr = frmUsrEdit.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                    }
                    //TODO - Button Clicked - Execute Code Here
                }
            }
        }
    }
}
