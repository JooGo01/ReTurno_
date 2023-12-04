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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EjemploABM
{
    public partial class FormUsuarioEditar : MaterialSkin.Controls.MaterialForm
    {
        public int id;
        public Usuario usr_pb;
        public FormUsuarioEditar(Usuario usr)
        {
            InitializeComponent();
            id=usr.id;
            usr_pb = usr;
            txtNombre.Text = usr.nombre.ToString();
            txtApellido.Text=usr.apellido.ToString();
            txtDNI.Text=usr.dni.ToString();
            txtTelefono.Text=usr.telefono.ToString();
            txtEmail.Text=usr.email.ToString();
            txtContrasenia.Text=usr.contrasenia.ToString();
            Direccion direccion = new Direccion();
            direccion = usr.direccion;
            txtCalle.Text = direccion.calle.ToString();
            txtAltura.Text = direccion.altura.ToString();
            txtDepartamento.Text = direccion.departamento.ToString();
            txtPiso.Text = direccion.piso.ToString();
            txtCodPos.Text = direccion.codigo_postal.ToString();
            txtCiudad.Text = direccion.ciudad.ToString();
            txtProvincia.Text = direccion.provincia.ToString();
            cmbTipoUsuario.Items.Add("1- Vendedor");
            cmbTipoUsuario.Items.Add("2- Administrador");
            cmbTipoUsuario.Items.Add("3- Cliente");
            if (usr.tipo_usuario == "V")
            {
                cmbTipoUsuario.SelectedIndex = 0;
            }
            else if (usr.tipo_usuario == "A")
            {
                cmbTipoUsuario.SelectedIndex = 1;
            }
            else {
                cmbTipoUsuario.SelectedIndex = 2;
            }
        }

        private void FormUsuarioEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
            MessageBox.Show("Usuario Editado", "ReTurno");
        }

        private void editar()
        {
            editarDireccion();
            editarUsuario();
        }

        private void editarUsuario()
        {
            Direccion dire = usr_pb.direccion;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String dni = txtDNI.Text;
            String tel = txtTelefono.Text;
            String email = txtEmail.Text;
            String pass = txtContrasenia.Text;
            String[] id_tipoUsuario = cmbTipoUsuario.Text.Split('-');
            String tipoUsuario = "";
            if (id_tipoUsuario[0] == "1")
            {
                tipoUsuario = "V";
            }
            else if (id_tipoUsuario[0] == "2")
            {
                tipoUsuario = "A";
            }
            else if (id_tipoUsuario[0] == "3")
            {
                tipoUsuario = "C";
            }
            Usuario usr = new Usuario(usr_pb.id, nombre, apellido, dni, tel, email, pass, tipoUsuario, dire, 0);
            Usuario_Controller.editarUsuario(usr);
        }

        private void editarDireccion()
        {
            String calle = txtCalle.Text;
            int altura = Int32.Parse(txtAltura.Text);
            String cod_pos = txtCodPos.Text;
            int piso = Int32.Parse(txtPiso.Text);
            String prov = txtProvincia.Text;
            String ciudad = txtCiudad.Text;
            String dep = txtDepartamento.Text;
            Direccion_Controller.editarDireccion(usr_pb.direccion,calle,altura,cod_pos,piso,prov,ciudad,dep);
        }
    }
}
