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
    public partial class FormSucursalEditar : MaterialSkin.Controls.MaterialForm
    {
        public FormSucursalEditar()
        {
            InitializeComponent();
        }
        public Sucursal suc_pb;
        public FormSucursalEditar(Sucursal suc)
        {
            InitializeComponent();
            txtCalle.Text = suc.direccion.calle.ToString();
            txtCiudad.Text = suc.direccion.ciudad.ToString();
            txtProvincia.Text = suc.direccion.provincia.ToString();
            txtDepartamento.Text = suc.direccion.departamento.ToString();
            txtAltura.Text = suc.direccion.altura.ToString();
            txtPiso.Text = suc.direccion.piso.ToString();
            txtCodPos.Text = suc.direccion.codigo_postal.ToString();
            txtRazonSocial.Text = suc.cliente.razon_social.ToString();
            txtTelefono.Text = suc.telefono.ToString();
            suc_pb = suc;
        }

        private void FormSucursalEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
            MessageBox.Show("Sucursal editada con exito", "ReTurno");
        }

        private void editar() {
            editarDireccion();
            editarSucursal();
        }

        private void editarDireccion() {
            String calle = txtCalle.Text;
            int altura = Int32.Parse(txtAltura.Text);
            String cod_pos = txtCodPos.Text;
            int piso = Int32.Parse(txtPiso.Text);
            String prov = txtProvincia.Text;
            String ciudad = txtCiudad.Text;
            String dep = txtDepartamento.Text;
            Direccion_Controller.editarDireccion(suc_pb.direccion, calle, altura, cod_pos, piso, prov, ciudad, dep);
        }

        private void editarSucursal() {
            String tel = txtTelefono.Text;
            long lngTel = long.Parse(tel);
            Sucursal_Controller.editarSucursal(suc_pb, suc_pb.cliente, suc_pb.direccion, lngTel, 0);
        }
    }
}
