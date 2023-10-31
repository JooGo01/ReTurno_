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
    public partial class FormClienteEditar : MaterialSkin.Controls.MaterialForm
    {
        public Cliente cli_pub;
        public Usuario usr_pub;
        public FormClienteEditar()
        {
            InitializeComponent();
        }

        public FormClienteEditar(Cliente cli)
        {
            InitializeComponent();
            cli_pub = cli;
            Usuario usr = new Usuario();
            Direccion dire = new Direccion();
            Rubro rub_cli = new Rubro();
            rub_cli = cli.rubro;
            usr = cli.usr;
            usr_pub=usr;
            dire = usr.direccion;
            txtRazonSocial.Text=cli.razon_social.ToString();
            txtNombre.Text = usr.nombre.ToString();
            txtApellido.Text = usr.apellido.ToString();
            txtDNI.Text = usr.dni.ToString();
            txtTelefono.Text = usr.telefono.ToString();
            txtEmail.Text = usr.email.ToString();
            txtCalle.Text = dire.calle.ToString();
            txtAltura.Text = dire.altura.ToString();
            txtDepartamento.Text = dire.departamento.ToString();
            txtPiso.Text = dire.piso.ToString();
            txtCodPos.Text = dire.codigo_postal.ToString();
            txtCiudad.Text = dire.ciudad.ToString();
            txtProvincia.Text = dire.provincia.ToString();
            List<Rubro> listRubro = Rubro_Controller.obtenerTodos();
            int i = 0;
            foreach (Rubro rub in listRubro)
            {
                String textoRubro = rub.id.ToString() + "- " + rub.nombre.ToString();
                cmbRubro.Items.Add(textoRubro);
                if (rub.id==rub_cli.id)
                {
                    cmbRubro.SelectedIndex = i;
                }
                i = i + 1;
            }
        }

        private void FormClienteEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editar()
        {
            editarDireccion();
            editarUsuario();
            editarCliente();
        }

        private void editarUsuario()
        {
            Direccion dire = usr_pub.direccion;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String dni = txtDNI.Text;
            String tel = txtTelefono.Text;
            String email = txtEmail.Text;
            String pass = txtContrasenia.Text;
            String tipoUsuario = "S";
            Usuario usr = new Usuario(usr_pub.id, nombre, apellido, dni, tel, email, pass, tipoUsuario, dire, 0);
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
            Direccion_Controller.editarDireccion(usr_pub.direccion, calle, altura, cod_pos, piso, prov, ciudad, dep);
        }

        private void editarCliente() {
            String rzn_social = txtRazonSocial.Text;
            String[] id_rub = cmbRubro.Text.Split('-');
            Rubro rub = new Rubro();
            rub = Rubro_Controller.obtenerPorId(Int32.Parse(id_rub[0]));
            Cliente_Controller.editarCliente(cli_pub, rub, rzn_social, 0);
        }
    }
}
