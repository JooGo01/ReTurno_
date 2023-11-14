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
    public partial class FormSucursales : MaterialSkin.Controls.MaterialForm
    {
        public FormSucursales()
        {
            InitializeComponent();
        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSucursales_Load(object sender, EventArgs e)
        {
            txtRazonSocial.Enabled = false;
            txtRazonSocial.Text = Program.cli.razon_social.ToString();
        }

        private void crearSucursal()
        {
            int id_dire = Direccion_Controller.obtenerMaxId();
            Direccion dire = Direccion_Controller.obtenerPorId(id_dire);
            long telefono = long.Parse(txtTelefono.Text);
            Sucursal suc = new Sucursal();
            suc.cliente = Program.cli;
            suc.id = (Sucursal_Controller.obtenerMaxId() + 1);
            suc.direccion = dire;
            suc.telefono = telefono.ToString();
            suc.estado_baja = 0;
            Sucursal_Controller.crearSucursal(suc);
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

        private void crear() {
            crearDireccion();
            crearSucursal();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            crear();
            MessageBox.Show("Sucursal dada de alta con exito", "ReTurno");
        }
    }
}
