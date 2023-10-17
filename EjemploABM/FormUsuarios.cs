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

namespace EjemploABM
{
    public partial class FormUsuarios : Form
    {
        string situacion;
        int id_editar;

        public FormUsuarios()
        {
            InitializeComponent();

            combo_tipo.Items.Clear();

            combo_tipo.Items.Add("Admin");
            combo_tipo.Items.Add("Vendedor");

            situacion = "creacion";
        }


        // SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormUsuarios(Usuario usr)
        {
            InitializeComponent();

            id_editar = usr.id;

            txt_usuario.Text = usr.email.ToString();
            txt_contraseña.Text = usr.contrasenia.ToString();
            txt_nombre.Text = usr.nombre.ToString();
            txt_apellido.Text = usr.apellido.ToString();

            combo_tipo.Items.Clear();
            combo_tipo.Items.Add("Admin");
            combo_tipo.Items.Add("Vendedor");

            if (Int32.Parse(usr.tipo_usuario) == 1)
            {
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                combo_tipo.SelectedIndex = 1;
            }

            situacion = "edicion";

            label2.Text = "Editar Usuario";
            btn_crear.Text = "Editar";


        }

        private void btn_crear_Click(object sender, EventArgs e)
        {

            if (situacion == "creacion")
            {
                crear();
            }
            if (situacion == "edicion")
            {
                editar();
            }
        }

        private void crear()
        {
            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            /*Usuario usr = new Usuario(0, txt_usuario.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text, tipo);

            if (Usuario_Controller.crearUsuario(usr))
            {
                this.DialogResult = DialogResult.OK;
            }*/
        }

        private void editar()
        {
            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            //Usuario usr = new Usuario(id_editar, txt_usuario.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text, tipo);
            //usr = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), Direccion_Controller.obtenerPorId(reader.GetInt32(8)), reader.GetInt32(9));

            /*if (Usuario_Controller.editarUsuario(usr))
            {
                this.DialogResult = DialogResult.OK;
            }*/
        }

    }
}
