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
    public partial class FormUsuario : MaterialSkin.Controls.MaterialForm
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.Add("1- Vendedor");
            cmbTipoUsuario.Items.Add("2- Administrador");
            cmbTipoUsuario.Items.Add("3- Cliente");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void crear() {
            crearDireccion();
            crearUsuario();
        }

        private void crearUsuario() {
            int id_dire = Direccion_Controller.obtenerMaxId();
            Direccion dire = Direccion_Controller.obtenerPorId(id_dire);
            int id_usr = Usuario_Controller.obtenerMaxId();
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String dni = txtDNI.Text;
            String tel = txtTelefono.Text;
            String email = txtEmail.Text;
            String pass = txtContrasenia.Text;
            String[] id_tipoUsuario = cmbTipoUsuario.Text.Split('-');
            String tipoUsuario="";
            if (id_tipoUsuario[0]=="1") {
                tipoUsuario = "V";
            } else if (id_tipoUsuario[0] == "2") {
                tipoUsuario = "A";
            } else if (id_tipoUsuario[0] == "3") {
                tipoUsuario = "C";
            }
            Usuario usr = new Usuario((id_usr + 1), nombre, apellido, dni, tel, email, pass, tipoUsuario, dire, 0);
            Usuario_Controller.crearUsuario(usr);
        }

        private void crearDireccion() {
            String calle = txtCalle.Text;
            int altura = Int32.Parse(txtAltura.Text);
            String cod_pos = txtCodPos.Text;
            int piso = Int32.Parse(txtPiso.Text);
            String prov = txtProvincia.Text;
            String ciudad = txtCiudad.Text;
            String dep = txtDepartamento.Text;
            Direccion_Controller.crearDireccion(calle,altura,cod_pos,piso,prov,ciudad,dep);
        }
    }
}
