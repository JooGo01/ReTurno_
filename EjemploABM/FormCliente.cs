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

namespace EjemploABM
{
    public partial class FormCliente : MaterialSkin.Controls.MaterialForm
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            List<Rubro> listRubro = Rubro_Controller.obtenerTodos();
            foreach (Rubro rub in listRubro)
            {
                String textoRubro = rub.id.ToString() + "- " + rub.nombre.ToString();
                cmbRubro.Items.Add(textoRubro);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            crear();
        }

        private void crear()
        {
            crearDireccion();
            crearUsuario();
            crearCliente();
        }

        private void crearUsuario()
        {
            int id_dire = Direccion_Controller.obtenerMaxId();
            Direccion dire = Direccion_Controller.obtenerPorId(id_dire);
            int id_usr = Usuario_Controller.obtenerMaxId();
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String dni = txtDNI.Text;
            String tel = txtTelefono.Text;
            String email = txtEmail.Text;
            String pass = txtContrasenia.Text;
            String tipoUsuario = "S";
            Usuario usr = new Usuario((id_usr + 1), nombre, apellido, dni, tel, email, pass, tipoUsuario, dire, 0);
            Usuario_Controller.crearUsuario(usr);
        }

        private void crearDireccion()
        {
            String calle = txtCalle.Text;
            int altura = Int32.Parse(txtAltura.Text);
            String cod_pos = txtCodPos.Text;
            int piso = Int32.Parse(txtPiso.Text);
            String prov = txtProvincia.Text;
            String ciudad = txtCiudad.Text;
            String dep = txtDepartamento.Text;
            Direccion_Controller.crearDireccion(calle, altura, cod_pos, piso, prov, ciudad, dep);
        }

        private void crearCliente() {
            Usuario usr = new Usuario();
            int id_usr = 0;
            id_usr = Usuario_Controller.obtenerMaxId();
            usr=Usuario_Controller.obtenerPorId(id_usr);
            String razon_social = txtRazonSocial.Text;
            String[] rubro_seleccionado = cmbRubro.Text.Split('-');
            Rubro rub = new Rubro();
            rub = Rubro_Controller.obtenerPorId(Int32.Parse(rubro_seleccionado[0]));
            Cliente_Controller.crearCliente(razon_social, rub, usr);
        }
    }
}
