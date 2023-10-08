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

namespace EjemploABM.ControlesDeUsuario
{
    public partial class Usuarios_UC : UserControl
    {
        List<Usuario> users;

        public Usuarios_UC()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            users = Usuario_Controller.obtenerTodos();
            dataGridView1.Rows.Clear();
            foreach(Usuario usr in users)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = usr.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = usr.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = usr.Apellido.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = usr.usuario.ToString();
                if(usr.Id_tipo.ToString() == "1")
                {
                    dataGridView1.Rows[rowIndex].Cells[4].Value = "Admin";

                }
                else
                {

                    dataGridView1.Rows[rowIndex].Cells[4].Value = "Vendedor";
                }
                dataGridView1.Rows[rowIndex].Cells[5].Value = "Editar";
                dataGridView1.Rows[rowIndex].Cells[6].Value = "Eliminar";

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUser = new FormUsuarios();
            DialogResult dr = frmUser.ShowDialog();

            if(dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");
                //ACTUALIZAR LA LISTA
                cargarUsuarios();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("el id es: " + id);

                Usuario user_editar = Usuario_Controller.obtenerPorId(id);

                FormUsuarios frmUser = new FormUsuarios(user_editar);

                DialogResult dr = frmUser.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");
                    //ACTUALIZAR LA LISTA
                    cargarUsuarios();

                }

            }

        }
    }
}
